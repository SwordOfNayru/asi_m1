namespace Université.Entity
{
    public class Etudier
    {

        public int? LEtudiantID { get; set; }

        public Etudiant LEtudiant { get; set; }

        public int? LUEID { get; set; }

        public UE LUE { get; set; }

    }
}
