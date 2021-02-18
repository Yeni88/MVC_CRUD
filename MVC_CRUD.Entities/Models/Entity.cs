using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_CRUD.Entities.Models
{
   public class Entity
    {
        public DateTime FechaCreacion { get; set; }
        public string UsuarioCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
        public string UsuarioModificacion { get; set; }
    }
}
