using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopManagement.Model
{
    public class Product
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string productId { get; set; }
        public string productName { get; set; }
        public string productPrice { get; set; }
    }
}
