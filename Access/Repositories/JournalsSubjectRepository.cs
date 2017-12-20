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
    public class JournalsSubjectRepository : IRepository<JournalSubject>
    {
        private AccessContext accessContext;

        public JournalsSubjectRepository(AccessContext p_accessContext)
        {
            accessContext = p_accessContext;
        }

        public IEnumerable<JournalSubject> Find(Func<JournalSubject, bool> predicate)
        {
            return accessContext.JournalsSubject.Where(predicate).ToList();
        }

        public JournalSubject Get(int id)
        {
            return accessContext.JournalsSubject.Find(id);
        }

        public IEnumerable<JournalSubject> GetAll()
        {
            return accessContext.JournalsSubject.Local.ToBindingList();
        }

        public void Insert(JournalSubject obj)
        {
            accessContext.JournalsSubject.Add(obj);
        }

        public void Update(JournalSubject obj)
        {
            accessContext.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(JournalSubject obj)
        {
            accessContext.JournalsSubject.Remove(obj);
        }

        public void Load()
        {
            accessContext.JournalsSubject.Load();
        }
    }
}
