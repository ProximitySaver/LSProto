namespace LinguoSphèreProt.Models
{
    public static class TestData
    {
        public static List<Niveau> GenerateNiveaux()
        {
            var niveaux = new List<Niveau>
            {
                new Niveau
                {
                    nom = "Beginner"
                },
                new Niveau
                {
                    nom = "Intermediate"
                }
            };
            return niveaux;
        }
    }
}
