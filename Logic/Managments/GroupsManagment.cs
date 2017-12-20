using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Interfaces;
using Access;

namespace Logic.Managments
{
    public class GroupsManagment : IManagment<Group>
    {
        private UnitOfWork unitOfWork { get; }

        public GroupsManagment()
        {
            unitOfWork = new UnitOfWork("DefaultConnection");
        }

        public void Insert(Group obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            unitOfWork.Groups.Insert(obj);
        }

        public void Update(Group obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            unitOfWork.Groups.Update(obj);
        }

        public void Delete(Group obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            unitOfWork.Groups.Delete(obj);
        }

        public void Load() => unitOfWork.Groups.Load();

        public IEnumerable<Group> Find(Func<Group, bool> predicate) => unitOfWork.Groups.Find(predicate);

        public Group GetItem(int id) => unitOfWork.Groups.Get(id);

        public IEnumerable<Group> GetList() => unitOfWork.Groups.GetAll();

        public void SaveChanges() => unitOfWork.SaveChanges();
    }
}
