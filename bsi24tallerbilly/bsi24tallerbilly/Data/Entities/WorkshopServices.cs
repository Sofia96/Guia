using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace bsi24tallerbilly.Data.Entities
{
    public class WorkshopServices
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WorkshopServicesID { get; set; }
        public string ImageURL { get; set; }
        public string Title { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(300)]
        public string Description { get; set; }
    }
}