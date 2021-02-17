
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CRUD.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public Supplier supplier { get; set; }

        public Category category { get; set; }


        public double UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public int UnitsOnOrder { get; set; }

        public int ReorderLevel { get; set; }

        public int Discontinued { get; set; }


    }
}