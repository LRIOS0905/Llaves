using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoLlaves.Models
{
    public class Proveedor
    {
        [Key]
        public int ProveedorID { get; set; }

       
        public string Nombre { get; set; }

       
        public string Apellido { get; set; }

        [Display(Name = "Nombre Empresa")]
        public int EmpresasID { get; set; }

        public virtual Empresas Empresas { get; set; }
       
    }
}