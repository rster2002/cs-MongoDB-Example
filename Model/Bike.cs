using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model {
    public class Bike: IEntity {
        [BsonRepresentation(BsonType.ObjectId)]
        public string id { get; set; }
        public string model { get; set; }

        public override string ToString() {
            return $"{id}: {model}";
        }
    }
}
