using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Université.Entity
{
    public class Formation
    {
        public int ID { get; set; }

        public string Intitule { get; set; }

        public int AnneDiplome { get; set; }

        public ICollection<Etudiant> EtudiantsInscrits { get; set; }

        public ICollection<UE> UEProposee { get; set; }

        [Display(Name = "Nombre d'inscrits")]
        public int NbInscrits { get
            {
                if(EtudiantsInscrits != null)
                {
                    return EtudiantsInscrits.Count;
                }
                return -1;
            } 
        }

        [Display(Name = "Nombre d'UE")]
        public int NbUE { get => UEProposee != null ? UEProposee.Count : -1; }
    }
}
