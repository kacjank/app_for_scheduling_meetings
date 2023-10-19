using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_do_awizacji.Model
{
    [Table("Meetings")]
    public class Meeting
    {
        [Key] public int Id { get; set; }
        public int WorkerId { get; set; }
        public int GuestId { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }

        // Pola potrzebne do stworzenia relacji
        public Worker Worker { get; set; }
        public Guest Guest { get; set; }
    }
}
