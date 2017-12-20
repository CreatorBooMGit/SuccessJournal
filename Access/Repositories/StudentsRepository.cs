using Access.Interfaces;
using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Access.Repositories
{
    public class StudentsRepository : IRepository<Student>
    {
        private AccessContext accessContext;

        public StudentsRepository(AccessContext p_accessContext)
        {
            accessContext = p_accessContext;
        }

        public IEnumerable<Student> Find(Func<Student, bool> predicate)
        {
            return accessContext.Students.Where(predicate).ToList();
        }

        public Student Get(int id)
        {
            return accessContext.Students.Find(id);
        }

        public IEnumerable<Student> GetAll()
        {
            return accessContext.Students.Local.ToBindingList();
        }

        public void Insert(Student obj)
        {
            accessContext.Students.Add(obj);
        }

        public void Update(Student obj)
        {
            accessContext.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(Student obj)
        {
            accessContext.Students.Remove(obj);
        }

        public void Load()
        {
            accessContext.Students.Load();
        }
    }
}
