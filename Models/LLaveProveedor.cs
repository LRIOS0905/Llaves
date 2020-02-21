using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoLlaves.Models
{
    public class LLaveProveedor
    {
        [Key]
        public int LLaveProveedorID { get; set; }
        public int EmpresasID { get; set; }
        public int ProveedorID { get; set; }

        public virtual Proveedor Proveedor { get; set; }
        public virtual Llaves Llave { get; set; }
    }
}