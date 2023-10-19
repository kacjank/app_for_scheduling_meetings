using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_do_awizacji.Model
{
    [Table("Workers")] //[Table("nazwa_tabeli")] zmapuje do sql-a tabelę pod podaną nazwą
                       //zamiast nazwy klasy (tabela "Workers" a nie "Worker")
    public class Worker
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Phone { get; set; }

        //Pola potrzebne do utworzenia relacji:
        public IEnumerable<Guest>? Guests { get; set; } //Pracownik może dodać wielu gości
        public IEnumerable<Meeting>? Meetings { get; set; } //Pracownik może utworzyć wiele awizacji
    }
}
