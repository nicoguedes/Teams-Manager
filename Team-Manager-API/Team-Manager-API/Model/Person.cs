using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Manager_API.Model
{
    public class Person
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Enumerators.PersonType Type { get; set; }
        public DateTime DateOfBirth { get; set; }
        public IList<Event> EventsAsMember { get; set; }
        public IList<Event> EventsAsCoordinator { get; set; }
    }
}
