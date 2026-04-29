namespace zeropos
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            using (LoginForm login = new LoginForm())
            {
                var result = login.ShowDialog();

                if (result == DialogResult.OK && UserSession.IsLoggedIn)
                {
                    if (UserSession.IsAdmin())
                    {
                        Application.Run(new Form1());
                    }
                    else if (UserSession.IsStaff())
                    {
                        Application.Run(new Form1());
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}