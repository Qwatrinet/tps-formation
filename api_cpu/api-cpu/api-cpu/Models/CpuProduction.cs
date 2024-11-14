using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace api_cpu.Models
{
    [Table("cpu_production")]
    public class CpuProduction
    {
        public int Id { get; set; }

        [MaxLength(60)]
        [Required]
        public string Nom {  get; set; }

        [Required]
        public int DureeProd {  get; set; }

        [ForeignKey("Cpu")]
        [Required]
        public int CpuId { get; set; }

        [JsonIgnore]
        public Cpu? Cpu { get; set; }

    }
}
