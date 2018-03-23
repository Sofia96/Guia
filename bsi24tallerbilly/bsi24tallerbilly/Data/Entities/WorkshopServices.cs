using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bsi24tallerbilly.Data.Entities
{
    public class WorkshopServices
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int WorkshopServicesID { get;}
        public string ImageURL { get; set; }
        public string Title { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(300)]
        public string Description { get; set; }
    }
}
