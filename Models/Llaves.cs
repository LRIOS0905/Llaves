using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProyectoLlaves.Models
{
    public class Llaves
    {
        [Key]
        public int ID { get; set; }

        [Display(Name = "Id Sitio")]
        public float IdSitio { get; set; }

        [Display(Name = "Nombre del Sitio")]
        [Required(ErrorMessage = "Debes ingresar {0}")]
        [DataType(DataType.MultilineText)]
        public string NombreSitio { get; set; }

        [Required(ErrorMessage = "Debes ingresar {0}")]
        [Display(Name = "OT / FG")]
        public string OTFG { get; set; }

        [Display(Name = "Retira")]
        [Required(ErrorMessage = "Debes ingresar {0}")]
        public string QuienRetira { get; set; }

        [Required(ErrorMessage = "Debes ingresar {0}")]
        public string Empresa { get; set; }
        public string Celular { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Display(Name = "Solicita")]
        public DateTime Fecha { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString ="{0:hh:mm}", ApplyFormatInEditMode =true)]
        public DateTime Hora { get; set; }

        [Display(Name = "OE")]
        public String OperadorEntrega { get; set; }

        [Display(Name = "Cant Llaves")]
        public string LlaveMecanica { get; set; }

        [Display(Name = "Pin Llave")]
        public string LlaveAcsys { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        [Display(Name = "Entrega")]
        public Nullable <DateTime> FechaRetorno { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh:mm}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hora")]
        public Nullable <DateTime> HoraRetorno { get; set; }

        [Display(Name = "OR")]
        public String OperadorRecibe { get; set; }

        [DataType(DataType.MultilineText)]
        public String Comentarios { get; set; }

        public virtual ICollection<LLaveProveedor> LLaveProveedors { get; set; }

    }
}