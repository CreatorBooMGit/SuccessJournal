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
    public class MarksRepository : IRepository<Mark>
    {
        private AccessContext accessContext;

        public MarksRepository(AccessContext p_accessContext)
        {
            accessContext = p_accessContext;
        }

        public IEnumerable<Mark> Find(Func<Mark, bool> predicate)
        {
            return accessContext.Marks.Where(predicate).ToList();
        }

        public Mark Get(int id)
        {
            return accessContext.Marks.Find(id);
        }

        public IEnumerable<Mark> GetAll()
        {
            return accessContext.Marks.Local.ToBindingList();
        }

        public void Insert(Mark obj)
        {
            accessContext.Marks.Add(obj);
        }

        public void Update(Mark obj)
        {
            accessContext.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(Mark obj)
        {
            accessContext.Marks.Remove(obj);
        }

        public void Load()
        {
            accessContext.Marks.Load();
        }
    }
}
