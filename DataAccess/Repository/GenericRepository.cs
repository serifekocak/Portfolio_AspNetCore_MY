using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            // Context c = new Context();  ----> bu yapıda c nesnesi programcı nesneyi silene kadar bellekte tutulur.
            using var c = new Context(); //----> bu yapıda ise nesne kullanımı bittiğinde, nesne otomatik olarak bellekten silinir. (Bellek yönetimini kolaylaştırır)
            c.Remove(t);
            c.SaveChanges();    
        }

        public T GetByID(int id)
        {
            using var c = new Context();
            return c.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var c = new Context();
            c.Add(t);
            c.SaveChanges();    
        }

        public void Update(T t)
        {
            using var c = new Context();
            c.Update(t);
            c.SaveChanges();    
        }
    }
}
