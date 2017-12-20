using Access.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Repositories
{
    public class TeachersRepository : IRepository<Teacher>
    {
        private AccessContext accessContext;

        public TeachersRepository(AccessContext p_accessContext)
        {
            accessContext = p_accessContext;
        }

        public IEnumerable<Teacher> Find(Func<Teacher, bool> predicate)
        {
            return accessContext.Teachers.Where(predicate).ToList();
        }

        public Teacher Get(int id)
        {
            return accessContext.Teachers.Find(id);
        }

        public IEnumerable<Teacher> GetAll()
        {
            return accessContext.Teachers.Local.ToBindingList();
        }

        public void Insert(Teacher obj)
        {
            accessContext.Teachers.Add(obj);
        }

        public void Update(Teacher obj)
        {
            accessContext.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(Teacher obj)
        {
            accessContext.Teachers.Remove(obj);
        }

        public void Load()
        {
            accessContext.Teachers.Load();
        }
    }
}
