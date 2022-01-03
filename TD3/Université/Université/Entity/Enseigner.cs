namespace Université.Entity
{
    public class Enseigner
    {
        public int ID { get; set; }

        public int LenseignantID { get; set; }
        public Enseignant Lenseignant { get; set; }

        public int LUEID { get; set; }
        public UE LUE { get; set; }
    }
}
