using Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace DAL {
    public class BaseRepo<T> : IRepo<T> where T : IEntity {
        private IMongoDatabase mongoDatabase;
        private IMongoCollection<T> collection;

        public BaseRepo(string databaseName, string collectionName) {
            string connectionString = ConfigurationManager.ConnectionStrings["MongoDBConnectionString"].ConnectionString;
            MongoClient client = new MongoClient(connectionString);
            mongoDatabase = client.GetDatabase(databaseName);
            collection = mongoDatabase.GetCollection<T>(collectionName);
        }

        public IEnumerable<T> getAll() {
            return collection.Find(item => true).ToList();
        }

        public IEnumerable<T> get(Func<T, bool> func) {
            return new List<T>();
            //return collection.Find(func).ToList();
        }

        public T get(string id) {
            return collection.Find(item => item.id == id).FirstOrDefault();
        }

        public void add(T entity) {
            collection.InsertOne(entity);
        }

        public void update(T entity) {
            collection.ReplaceOne(item => item.id == entity.id, entity);
        }

        public void addMultiple(T[] entities) {
            collection.InsertMany(entities);
        }

        public void delete(string id) {
            collection.DeleteOne(id);
        }

        public void delete(T entity) {
            delete(entity.id);
        }

        public void delete(Func<T, bool> func) {
            throw new NotImplementedException();
        }
    }
}
