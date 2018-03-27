using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace bsi24tallerbilly.Models.WorkshopServicesViewModel
{
    public class AddWorkshopServiceViewModel
    {
        [Key]
        public int WorkshopServicesID { get; set; }
        [Display(Name = "Url Imagen")]
        public string ImageURL { get; set; }
        [Required(ErrorMessage ="Este espacio no puede quedar en blanco")]
        [Display(Name = "Titulo")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Este espacio no puede quedar en blanco")]
        [StringLength(300, ErrorMessage ="Demasiado texto en la casilla")]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }
    }
}