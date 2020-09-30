using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL {
    public interface IRepo<T> where T : IEntity {
        // Create
        void add(T entity);
        void addMultiple(T[] entities);

        // Read
        IEnumerable<T> getAll();
        T get(string id);
        IEnumerable<T> get(Func<T, bool> func);

        // Update
        void update(T entity);

        // Delete
        void delete(string id);
        void delete(T entity);
        void delete(Func<T, bool> func);
    }
}
