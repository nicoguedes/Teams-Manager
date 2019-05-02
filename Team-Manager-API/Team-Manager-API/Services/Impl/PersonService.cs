using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeamManagerApi.Model;

namespace TeamManagerApi.Services.Impl
{
    public class PersonService : GenericService<Person>, IPersonService
    {
        public PersonService(IConfiguration config) : base(config) { }
    }
}
