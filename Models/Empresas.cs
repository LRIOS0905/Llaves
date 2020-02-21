using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoLlaves.Models
{
    public class Empresas
    {
        [Key]
        public int EmpresasID{ get; set; }

     
        public string Descripcion { get; set; }

        public virtual ICollection<Proveedor> Proveedores { get; set; }
    }
}