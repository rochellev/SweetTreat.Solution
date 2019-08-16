using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SweetTreat.Models
{
    [Table("TreatFlavor")]
    public class TreatFlavor
    {
        [Key]
        public int TreatFlavorId {get; set;}
        public int TreatId {get; set;}
        public int FlavorId {get; set;}
        public Treat Treat {get; set;}
        public Flavor Flavor {get; set;}
    }
}