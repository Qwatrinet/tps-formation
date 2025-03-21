﻿using System.ComponentModel.DataAnnotations;

namespace testCpu.Models
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
    }
}
