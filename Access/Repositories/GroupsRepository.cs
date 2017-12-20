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
    public class GroupsRepository : IRepository<Group>
    {
        private AccessContext accessContext;

        public GroupsRepository(AccessContext p_accessContext)
        {
            accessContext = p_accessContext;
        }

        public IEnumerable<Group> Find(Func<Group, bool> predicate)
        {
            return accessContext.Groups.Where(predicate).ToList();
        }

        public Group Get(int id)
        {
            return accessContext.Groups.Find(id);
        }

        public IEnumerable<Group> GetAll()
        {
            return accessContext.Groups.Local.ToBindingList();
        }

        public void Insert(Group obj)
        {
            accessContext.Groups.Add(obj);
        }

        public void Update(Group obj)
        {
            accessContext.Entry(obj).State = EntityState.Modified;
        }

        public void Delete(Group obj)
        {
            accessContext.Groups.Remove(obj);
        }

        public void Load()
        {
            accessContext.Groups.Load();
        }
    }
}
