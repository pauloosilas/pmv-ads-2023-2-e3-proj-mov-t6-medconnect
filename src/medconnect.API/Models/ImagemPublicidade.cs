using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace medconnect.API.Models
{
    public class ImagemPublicidade
    {
        [Key]
        public int Id { get; set; }

        [JsonIgnore]
        public Especialista? Especialista { get; set; }

        [StringLength(350)]
        public string UrlImage { get; set; }
    }
}
