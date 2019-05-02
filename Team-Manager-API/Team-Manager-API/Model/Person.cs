using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagerApi.Model
{
    public class Person : IBaseModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }
        public PersonType Type { get; set; }
        public DateTime DateOfBirth { get; set; }
        public IList<Event> EventsAsMember { get; set; }
        public IList<Event> EventsAsCoordinator { get; set; }
        
    }
}
