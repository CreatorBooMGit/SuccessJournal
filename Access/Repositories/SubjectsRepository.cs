using Access.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Access.Repositories
{
    public class SubjectsRepository : IRepository<Subject>
    {
        private AccessContext accessContext;

        public SubjectsRepository(AccessContext p_accessContext)
        {
            accessContext = p_accessContext;
        }

        public IEnumerable<Subject> Find(Func<Subject, bool> predicate)
        {
            return accessContext.Subjects.Where(predicate).ToList();
        }

        public Subject Get(int id)
        {
            return accessContext.Subjects.Find(id);
        }

        public IEnumerable<Subject> GetAll()
        {
            return accessContext.Subjects.Local.ToBindingList();
        }

        public void Insert(Subject obj)
        {
            accessContext.Subjects.Add(obj);
        }

        public void Update(Subject obj)
        {
            accessContext.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(Subject obj)
        {
            accessContext.Subjects.Remove(obj);
        }

        public void Load()
        {
            accessContext.Subjects.Load();
        }
    }
}
