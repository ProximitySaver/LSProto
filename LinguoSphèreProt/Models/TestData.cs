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
                    Nom = "Beginner"
                },
                new Niveau
                {
                    Nom = "Intermediate"
                }
            }; 
            return niveaux;
        }

        public static List<Langage> GenerateLangages()
        {
            var langages = new List<Langage>
            {
                new Langage
                {
                    Nom = "French"
                },
                new Langage
                {
                    Nom = "English"
                }
            };
            return langages;
        }

        public static List<Feature> GenerateFeatures()
        {
            var features = new List<Feature>
            {
                new Feature
                {
                    Nom = " Interactive , Cultural Immersion , Speaking Practice "
                },
                new Feature
                {
                    Nom = " Business Vocabulary , Email Writing , Networking "
                }
            };
            return features;
        }

        public static List<Course> GenerateCourses(List<Feature> features , List<Niveau> niveaux , List<Langage> langages)
        {
            var courses = new List<Course>();
            
            if(features.Count > 0 && niveaux.Count > 0 && langages.Count > 0)
            {
                courses.Add(new Course
                {
                    CourseNumber = "1",
                    Titre = "Everyday Conversations",
                    Description = "Interactive French course focused on daily interactions and essential phrases.",
                    Objectives = "To equip learners with basic conversational skills in French for everyday situations.",
                    PhotoURL = "~/images/1.jpg",
                    DateDebut = new DateTime(2024,6,1),
                    Niveau = niveaux[0],
                    Langue = langages[0],
                    Features = features[0]
                });
                courses.Add(new Course
                {
                    CourseNumber = "2",
                    Titre = "Business French Essentials",
                    Description = "A course designed for professionals to enhance their business communication in French.",
                    Objectives = "To develop language skills for business contexts, including negotiations and presentations.",
                    PhotoURL = "~/images/2.jpg",
                    DateDebut = new DateTime(2024, 7, 1),
                    Niveau = niveaux[1],
                    Langue = langages[0],
                    Features = features[1]
                });
            }
            return courses;
        }
    }
}
