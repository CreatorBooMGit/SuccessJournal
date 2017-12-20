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
    public class SubjectsManagment : IManagment<Subject>
    {
        private UnitOfWork unitOfWork { get; }

        public SubjectsManagment()
        {
            unitOfWork = new UnitOfWork("DefaultConnection");
        }

        public void Insert(Subject obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            unitOfWork.Subjects.Insert(obj);
        }

        public void Update(Subject obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            unitOfWork.Subjects.Update(obj);
        }

        public void Delete(Subject obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            unitOfWork.Subjects.Delete(obj);
        }

        public void Load() => unitOfWork.Subjects.Load();

        public IEnumerable<Subject> Find(Func<Subject, bool> predicate) => unitOfWork.Subjects.Find(predicate);

        public Subject GetItem(int id) => unitOfWork.Subjects.Get(id);

        public IEnumerable<Subject> GetList() => unitOfWork.Subjects.GetAll();

        public void SaveChanges() => unitOfWork.SaveChanges();
    }
}
