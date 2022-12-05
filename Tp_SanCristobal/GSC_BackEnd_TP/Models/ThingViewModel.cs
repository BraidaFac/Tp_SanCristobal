using GSC_BackEnd_TP.Entities;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace GSC_BackEnd_TP.Models
{
    public class ThingViewModel
    {
        public Category? Category { get; set; }

        public int Id { get; set; }




        [Required(ErrorMessage = "Descripcion es obligatoria.")]
        public string Description { get; set; }
        
     


        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "La categoria es obligatoria.")]
        public int CategoryId { get; set; } 


        }
    
}
