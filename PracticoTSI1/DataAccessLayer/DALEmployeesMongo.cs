using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace DataAccessLayer
{
    public class DALEmployeesMongo : IDALEmployees
    {
        MongoClient mc = new MongoClient("mongodb://localhost:27017");

        public void AddEmployee(Employee emp)
        {
            try
            {
                IMongoDatabase db = mc.GetDatabase("Business");
                db.GetCollection<Employee>("Employee").InsertOneAsync(emp);
            }
            catch
            {
                throw;
            }
        }

        public void DeleteEmployee(int id)
        {
            try
            {
                IMongoDatabase db = mc.GetDatabase("Business");
                db.GetCollection<Employee>("Employee").DeleteOneAsync(e => e.Id == id);
            }
            catch
            {
                throw;
            }
        }

        public void UpdateEmployee(Employee emp)
        {
            try
            {
                IMongoDatabase db = mc.GetDatabase("Business");
                db.GetCollection<Employee>("Employee").ReplaceOneAsync(e => e.Id == emp.Id, emp);
            }
            catch
            {
                throw;
            }

            //Esto lo guardo como ejemplo.
            /*var collection = db.GetCollection<BsonDocument>("restaurants");
            var filter = Builders<BsonDocument>.Filter.Eq("restaurant_id", "41156888");
            var update = Builders<BsonDocument>.Update.Set("address.street", "East 31st Street");
            var result = collection.UpdateOneAsync(filter, update);*/
        }

        public List<Employee> GetAllEmployees()
        {
            try
            {
                IMongoDatabase db = mc.GetDatabase("Business");
                var lisEmpleado = db.GetCollection<Employee>("Employee").Find(_ => true).ToList();
                return lisEmpleado;
            }
            catch
            {
                throw;
            }
        }

        public Employee GetEmployee(int id)
        {
            try
            {
                IMongoDatabase db = mc.GetDatabase("Business");
                var colEmpleado = db.GetCollection<Employee>("Employee").Find(e => e.Id == id);
                return colEmpleado.FirstOrDefault();
            }
            catch
            {
                throw;
            }
        }
    }
}
