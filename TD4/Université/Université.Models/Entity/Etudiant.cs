using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Université.Models.Entity
{
    public class Etudiant
    {
        public int ID { get; set; }
        [Required]
        public string Nom { get; set; }
        [Required]
        public string Prenom { get; set; }
        [Display(Name = "Date naissance")]
        [DataType(DataType.Date)]
        public DateTime Naissance { get; set; }

        [Required]
        public string NumeroEtudiant { get; set; }

        public int? FormationSuivieID { get; set; }

        public Formation FormationSuivie { get; set; }
    }
}
