﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Manager_API.Model
{
    public class Team
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public IList<Person> Coordinators { get; set; }
        public IList<Person> Members { get; set; }
    }
}
