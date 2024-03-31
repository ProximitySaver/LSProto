using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Hosting;

namespace LinguoSphèreProt.Models
{
    public class Feature
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? FeatureID { get; set; }
        public string? nom { get; set; }
    }
}
