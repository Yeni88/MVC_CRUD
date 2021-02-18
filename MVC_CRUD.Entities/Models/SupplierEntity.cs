using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_CRUD.Entities.Models
{
   public class SupplierEntity : Entity
    {
        public int SupplierID { get; set; }
        public string ContactTitle { get; set; }
    }
}
