using System.ComponentModel.DataAnnotations;

namespace IT_Télé_Faune.Models
{
    public class ServiceBase
    {
        public int Id { get; set; }
        [Required]
        public string type_service { get; set; }

    }
}