using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace medconnect.API.Models
{
    public class Especialista : Cliente
    {
     
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid EspecialistaId { get; set; }
        public IEnumerable<Atendimento>? Atendimentos { get; set; }

        [StringLength(350)]
        public string DescricaoCurta { get; set; }

        [StringLength(5000)]
        public string DescricaoDetalhada { get; set; }

        [StringLength(200)]
        public string Especialidade { get; set; }

        public IEnumerable<ImagemPublicidade>? ImagemsPublicidade { get; set; }
    }
}
