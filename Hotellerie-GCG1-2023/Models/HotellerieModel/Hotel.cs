using System.ComponentModel.DataAnnotations;

namespace Hotellerie_GCG1_2023.Models.HotellerieModel
{
    public class Hotel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="The Nom attributes is Required !!!")]
        [StringLength(20,MinimumLength =3,ErrorMessage ="...")]
        public string Nom { get; set; }
        [Range(1,5,ErrorMessage ="...")]
        public int Etoiles { get; set; }
        [Required(ErrorMessage = "The Ville attributes is Required !!!")]
        public string Ville { get; set; }
        [Required]
        [Display(Name ="Site Web")]
        [RegularExpression(@"^(http|https)://([\w-]+.)+[\w-]+(/[\w- ./?%&=])?$",ErrorMessage ="sss")]
        public string SiteWeb { get; set; }
        public string Tel { get; set; }

        public virtual ICollection<Appreciation>? Appreciations { get; set; } =  new List<Appreciation>();

    }
}
