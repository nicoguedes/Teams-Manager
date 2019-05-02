using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Manager_API.Model
{
    public class Event
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public IList<Person> Coordinators { get; set; }
        public IList<Team> Teams { get; set; }
    }
}
