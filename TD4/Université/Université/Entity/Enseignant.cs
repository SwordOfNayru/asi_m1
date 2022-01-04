using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Université.Entity
{
    public class Enseignant
    {
        public int ID { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        [Display(Name = "UEs Enseignées")] 
        public ICollection<Enseigner> LesEnseigner { get; set; }

        public string NomComplet { get => $"{Nom} {Prenom}"; }

    }
}
