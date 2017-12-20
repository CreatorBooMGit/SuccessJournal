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
    public class JournalsRepository : IRepository<Journal>
    {
        private AccessContext accessContext;

        public JournalsRepository(AccessContext p_accessContext)
        {
            accessContext = p_accessContext;
        }

        public IEnumerable<Journal> Find(Func<Journal, bool> predicate)
        {
            return accessContext.Journals.Where(predicate).ToList();
        }

        public Journal Get(int id)
        {
            return accessContext.Journals.Find(id);
        }

        public IEnumerable<Journal> GetAll()
        {
            return accessContext.Journals.Local.ToBindingList();
        }

        public void Insert(Journal obj)
        {
            accessContext.Journals.Add(obj);
        }

        public void Update(Journal obj)
        {
            accessContext.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(Journal obj)
        {
            accessContext.Journals.Remove(obj);
        }

        public void Load()
        {
            accessContext.Journals.Load();
        }
    }
}
