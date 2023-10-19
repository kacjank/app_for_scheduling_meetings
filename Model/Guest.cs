using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_do_awizacji.Model
{
    [Table("Guests")]
    public class Guest
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AddedBy { get; set; }
        public int WorkerId { get; set; }

        //Pola potrzebne do utworzenia relacji:
        public Worker Worker { get; set; } //Pracownik, przez którego gość został dodany
        public IEnumerable<Meeting>? Meetings { get; set; } //Wszystkie awizacje dotyczące danego gościa
    }
}
