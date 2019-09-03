using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace SweetTreat.Models
{
    [Table("Treats")]
    public class Treat
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<TreatFlavor> Flavors { get; set; }
        public virtual ApplicationUser User { get; set; }
        
        public Treat()
        {
            this.Flavors = new HashSet<TreatFlavor>();
        }

    }
}