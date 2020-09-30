using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model {
    public class Car: IEntity {
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public string make { get; set; }
        public string model { get; set; }
        public int numberOfDoors { get; set; }
        public bool isDiesel { get; set; }
    }
}
