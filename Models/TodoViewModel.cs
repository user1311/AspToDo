using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreToDo.Models
{
    public class TodoViewModel
    {
        /*Zbog toga sto u modelu imam classu za jedan objekat to-do, ovdje imam listu objekata Todo tako da korisnik moze imati vise instanci*/
        public IEnumerable<TodoItem> Items { get; set; }

    }
}
