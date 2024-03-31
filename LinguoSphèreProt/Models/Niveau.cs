using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LinguoSphèreProt.Models
{
    public class Niveau
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? NiveauID { get; set; }
        public string? nom { get; set; }
    }
}
