using System.ComponentModel.DataAnnotations;

namespace IT_Télé_Faune.Models
{
    public class SiteBase
    {
        public int Id { get; set; }
        [Required]
        public string ville { get; set; }
        public int Id_service { get; set; }

    }
}
