using Microsoft.Data.Sqlite;
using System.Globalization;

namespace zeropos
{
    internal class BillCoder
    {
        public string BillPrefix { get; set; } = "BILL";

        public BillCoder()
        {
            InitCode();
        }

        private void InitCode()
        {
            Settings setting = new Settings();
            string prefix = setting.bill_prefix;

            if (string.IsNullOrWhiteSpace(prefix))
            {
                BillPrefix = "BILL";
            }
            else
            {
                BillPrefix = prefix;
            }
        }

        public string Generate()
        {
            Settings setting = new Settings();
            string prefix = setting.bill_prefix;

            if (string.IsNullOrWhiteSpace(prefix.ToString()))
                prefix = "BILL";

            string billDate = DateTime.Now.ToString(
                "yyyyMMdd",
                CultureInfo.InvariantCulture
            );

            using (SqliteConnection conn = DatabaseConnection.GetConnection())
            using (SqliteTransaction transaction = conn.BeginTransaction())
            {
                try
                {
                    int nextNumber = 1;

                    string selectQuery = @"
                        SELECT last_number
                        FROM bill_sequence
                        WHERE bill_date = @bill_date
                    ";

                    using (SqliteCommand selectCmd = new SqliteCommand(selectQuery, conn, transaction))
                    {
                        selectCmd.Parameters.AddWithValue("@bill_date", billDate);

                        object result = selectCmd.ExecuteScalar();

                        if (result == null || result == DBNull.Value)
                        {
                            string insertQuery = @"
                                INSERT INTO bill_sequence (bill_date, last_number)
                                VALUES (@bill_date, @last_number)
                            ";

                            using (SqliteCommand insertCmd = new SqliteCommand(insertQuery, conn, transaction))
                            {
                                insertCmd.Parameters.AddWithValue("@bill_date", billDate);
                                insertCmd.Parameters.AddWithValue("@last_number", 1);
                                insertCmd.ExecuteNonQuery();
                            }

                            nextNumber = 1;
                        }
                        else
                        {
                            int lastNumber = Convert.ToInt32(result);
                            nextNumber = lastNumber + 1;

                            string updateQuery = @"
                                UPDATE bill_sequence
                                SET last_number = @last_number
                                WHERE bill_date = @bill_date
                            ";

                            using (SqliteCommand updateCmd = new SqliteCommand(updateQuery, conn, transaction))
                            {
                                updateCmd.Parameters.AddWithValue("@last_number", nextNumber);
                                updateCmd.Parameters.AddWithValue("@bill_date", billDate);
                                updateCmd.ExecuteNonQuery();
                            }
                        }
                    }

                    transaction.Commit();

                    return $"{prefix}-{billDate}-{nextNumber.ToString("D4")}";
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public (string prefix, DateTime datetime, int? runningNumber) Decode(string billCode)
        {
            try
            {
                string[] parts = billCode.Split('-');

                string prefix = parts[0];

                // 🔥 แบบใหม่ (DB run)
                if (parts.Length == 3)
                {
                    DateTime date = DateTime.ParseExact(parts[1], "yyyyMMdd", null);
                    int running = int.Parse(parts[2]);

                    return (prefix, date, running);
                }
                // 🔥 แบบเก่า (time + ms)
                else if (parts.Length >= 4)
                {
                    DateTime dt = DateTime.ParseExact(
                        parts[1] + parts[2],
                        "yyyyMMddHHmmss",
                        null
                    );

                    return (prefix, dt, null);
                }
                else
                {
                    throw new Exception("format ไม่ถูกต้อง");
                }
            }
            catch
            {
                throw new Exception("decode ไม่สำเร็จ");
            }
        }
    }
}