using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeamManagerApi.Model
{
    public interface IBaseModel
    {
        [BsonId]
        string Id { get; set; }
    }
}
