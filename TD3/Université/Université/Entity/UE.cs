using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Université.Entity
{
    public class UE
    {
        public int ID { get; set; }

        public string Numero { get; set; }

        public string Intitule { get; set; }

        public int? FormationID { get; set; }

        public Formation Formation { get; set; }

        [Display(Name = "Enseignants de l’UE")]
        public ICollection<Enseigner> LesEnseigner { get; set; }
    }
}
