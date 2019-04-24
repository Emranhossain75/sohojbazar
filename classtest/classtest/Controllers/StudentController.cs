
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Demo1.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Demo1.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        MongoClient _client;
        MongoServer _server;
        MongoDatabase _db;

        public StudentController()
        {
            _client = new MongoClient("mongodb://localhost:27017");
            _server = _client.GetServer();
            _db = _server.GetDatabase("StudentDB");
        }

        public string getStudentNames()
        {
            return "Ali";
        }
        public string getStudentID()
        {
            return "112";
        }
        public void SaveStudentInfo(Student student)
        {
            //var document = new BsonDocument
            //{
            // {"property", "10"},
            // {"address", "this is address 1"},
            // {"city", "city name"}
            //};

            //Student aStudent = new Student();
            //aStudent.property = "10";
            //aStudent.address = "this is address 1";
            //aStudent.city = "city name";

            _db.GetCollection("Students").Save(student);
        }
        public IEnumerable<Object> ShowSavedData()
        {
            return _db.GetCollection<BsonDocument>("Students").FindAll();
        }
    }
}