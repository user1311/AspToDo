using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreToDo.Models
{
    public class TodoItem
    {
        public Guid Id { get; set; }
        public bool isDone { get; set; }
        public string Title { get; set; }
        public DateTimeOffset? DueAt {get;set;}


    }
}
