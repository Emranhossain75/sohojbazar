using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using ShopManagement.Model;

namespace ShopManagement.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class productController : ControllerBase
    {
        MongoClient _client;
        MongoServer _server;
        MongoDatabase _db;
        public productController()
        {
            _client = new MongoClient("mongodb://localhost:27017");
            _server = _client.GetServer();
            _db = _server.GetDatabase("productDB");
        }
        public void SaveProductInfo(Product productObj)
        {
            //var document = new BsonDocument
            //{
            //    {"productId", "10"},
            //    {"productName", "table"},
            //    {"productPrice", "1000"}
            //};
            //Product productObj = new Product();
            //productObj.productId = "001";
            //productObj.productName = "Pendrive";
            //productObj.productPrice = "800";

            //Student aStudent = new Student();
            //aStudent.property = "10";
            //aStudent.address = "Dhanmondi";
            //aStudent.city = "Dhaka";

            _db.GetCollection("Products").Save(productObj);

        }
        public IEnumerable<Object> ShowSavedData()
        {
            return _db.GetCollection("Products").FindAll();
        }
        public string getName()
        {
            return "Table";
        }
        public int getId()
        {
            return 121;
        }
    }
}