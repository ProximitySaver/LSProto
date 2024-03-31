using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LinguoSphèreProt.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseID { get; set; }
        public string? CourseNumber { get; set; }
        public string? Titre { get; set; }

        public string? Description { get; set; }

        public string? Objectives { get; set; }

        public string? PhotoURL { get; set; }

        public DateTime? DateDebut { get; set; }

        [ForeignKey("NiveauID")]
        public int NiveauID { get; set; }
        public virtual Niveau? Niveau { get; set; }


       [ForeignKey("LangueID")]
        public int LangueID { get; set; }
        public virtual Langage? Langue { get; set; }


        [ForeignKey("FeatureID")]
        public int FeatureID { get; set; }
        public virtual Feature? Features { get; set; }

    }
}
