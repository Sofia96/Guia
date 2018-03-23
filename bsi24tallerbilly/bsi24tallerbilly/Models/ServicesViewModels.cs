using bsi24tallerbilly.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bsi24tallerbilly.Models
{
    public class WorkShopServicesViewModel
    {
        public int WorkshopServicesID { get; set; }
        [Display(Name = "Url Imagen")]
        public string ImageURL { get; set; }
        [Required]
        [Display(Name = "Titulo")]
        public string Title { get; set; }
        [Required]
        [Display(Name = "Descripcion")]
        public string Description { get; set; }
    }

    public class WorkShopServicesList
    {
        public List<WorkshopServices> ListOfServices { get; set; }
    }

}
