using Access;
using Domain;
using Logic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Managments
{
    public class TeachersManagment : IManagment<Teacher>
    {
        private UnitOfWork unitOfWork { get; }

        public TeachersManagment()
        {
            unitOfWork = new UnitOfWork("DefaultConnection");
        }

        public void Insert(Teacher obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            unitOfWork.Teachers.Insert(obj);
        }

        public void Update(Teacher obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            unitOfWork.Teachers.Update(obj);
        }

        public void Delete(Teacher obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            unitOfWork.Teachers.Delete(obj);
        }

        public void Load() => unitOfWork.Teachers.Load();

        public IEnumerable<Teacher> Find(Func<Teacher, bool> predicate) => unitOfWork.Teachers.Find(predicate);

        public Teacher GetItem(int id) => unitOfWork.Teachers.Get(id);

        public IEnumerable<Teacher> GetList() => unitOfWork.Teachers.GetAll();

        public void SaveChanges() => unitOfWork.SaveChanges();
    }
}
