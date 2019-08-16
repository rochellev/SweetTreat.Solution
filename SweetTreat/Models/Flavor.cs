using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace SweetTreat.Models
{
    [Table("Flavors")]
    public class Flavor
    {
        [Key]
        public int ID {get; set;}
        public string Name { get; set;}
        public virtual ICollection<TreatFlavor> Treats {get; set;}

        public Flavor()
        {
            this.Treats = new HashSet<TreatFlavor>();
        }
    }
}