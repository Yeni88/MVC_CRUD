using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_CRUD.Entities.Models
{
    public class CategoryEntity : Entity
    {
        //public tipo nombre_atrib { get; set; }
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
