using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Université.Entity
{
    public class Note
    {
        public int Id { get; set; }

        public float Valeur { get; set; }

        public Etudier RelationEtudiant { get; set; }
    }
}
