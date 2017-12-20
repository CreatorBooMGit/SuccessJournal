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
    public class StudentsManagment : IManagment<Student>
    {
        private UnitOfWork unitOfWork { get; }

        public StudentsManagment()
        {
            unitOfWork = new UnitOfWork("DefaultConnection");
        }

        public void Insert(Student obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            unitOfWork.Students.Insert(obj);
        }

        public void Update(Student obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            unitOfWork.Students.Update(obj);
        }

        public void Delete(Student obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            unitOfWork.Students.Delete(obj);
        }

        public void Load() => unitOfWork.Students.Load();

        public IEnumerable<Student> Find(Func<Student, bool> predicate) => unitOfWork.Students.Find(predicate);

        public Student GetItem(int id) => unitOfWork.Students.Get(id);

        public IEnumerable<Student> GetList() => unitOfWork.Students.GetAll();

        public void SaveChanges() => unitOfWork.SaveChanges();
    }
}
