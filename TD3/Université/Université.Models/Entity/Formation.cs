using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Université.Models.Entity
{
    public class Formation
    {
        public int ID { get; set; }

        public string Intitule { get; set; }

        public int AnneDiplome { get; set; }

        public ICollection<Etudiant> EtudiantsInscrits { get; set; }
    }
}
