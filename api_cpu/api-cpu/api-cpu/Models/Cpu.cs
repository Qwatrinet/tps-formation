using System.ComponentModel.DataAnnotations;

namespace api_cpu.Models
{
    public class Cpu
    {
        public int Id { get; set; }

        [Required]
        public string Marque { get; set; }

        [Required]
        public string Famille { get; set; }

        [Required]
        public string Modele { get; set; }

        [Required]
        public float Frequence { get; set; }

        [Required]
        public int Prix { get; set; }

        [Required]
        public int Stock { get; set; }

        //public ICollection<Cpu>? Cpus { get; init; }

    }
}
