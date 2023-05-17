using PlakDukkanıProje.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkanıProje.Repository
{
    internal abstract class BaseRepository<T> where T : class
    {
        public BaseRepository()
        {
            db = new PlakDukkaniDB();
        }
        public PlakDukkaniDB db;

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public bool Add(T item)
        {
            db.Set<T>().Add(item);
            int count = db.SaveChanges();
            return count > 0;
        }

        public bool Update(T item)
        {
            db.Set<T>().Update(item);
            int count = db.SaveChanges();
            return count > 0;
        }

        public bool Remove(T item)
        {
            db.Set<T>().Remove(item);
            int count = db.SaveChanges();
            return count > 0;
        }
        public T? GetById(int id)
        {
            T? entity = db.Set<T>().Find(id);
            return entity;
        }
    }
}
