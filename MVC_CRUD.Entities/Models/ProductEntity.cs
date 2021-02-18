using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_CRUD.Entities.Models
{
    public class ProductEntity : Entity
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }

        public int SupplierID { get; set; }
        public string ProductName { get; set; }

        public SupplierEntity Supplier { get; set; }

        public CategoryEntity Category { get; set; }

        public int QuantityPerUnit { get; set; }

        public double UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public int UnitsOnOrder { get; set; }

        public int ReorderLevel { get; set; }

        public int Discontinued { get; set; }
    }
}
