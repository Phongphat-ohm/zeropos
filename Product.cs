using System;
using System.Collections.Generic;
using System.Text;

namespace zeropos
{
    internal class Product
    {
        public class ProductProps
        {
            public int id { get; set; }
            public string sku { get; set; }
            public string name { get; set; }
            public int category_id { get; set; }
            public string unit { get; set; }
            public int stock { get; set; }
            public float cost { get; set; }
            public float price { get; set; }
        }
    }
}
