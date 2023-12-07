using System.ComponentModel.DataAnnotations;

namespace Hotellerie_GCG1_2023.Models.HotellerieModel
{
    public class Appreciation
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="le nom est un champ obligatoire !!!")]
        [Display(Name ="Nom Personne")]
        public string NomPers {  get; set; }
        [Required(ErrorMessage ="....")]
        [DataType(DataType.MultilineText)]
        public string Commentaire { get; set; }
        public int HotelId { get; set; }
        public virtual Hotel? Hotel { get; set; } = null!;

    }
}
