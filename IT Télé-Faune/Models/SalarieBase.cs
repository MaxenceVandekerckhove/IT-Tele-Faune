using System.ComponentModel.DataAnnotations;

namespace IT_Télé_Faune.Models
{
    public class SalarieBase
    {
        public int Id { get; set; }
        [Required]
        public string nom { get; set; }
        public string prenom { get; set; }
        public int telephone_mobile { get; set; }
        public string telephone_fixe { get; set; }
        public string email { get; set; }
        public string ID_service { get; set; }
        public int ID_site { get; set; }

    }
}