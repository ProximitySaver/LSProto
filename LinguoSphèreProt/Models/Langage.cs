using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LinguoSphèreProt.Models
{
    public class Langage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LangageID { get; set; }
        public string? Nom {  get; set; }
    }
}
