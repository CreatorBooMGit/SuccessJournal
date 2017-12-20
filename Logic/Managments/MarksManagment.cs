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
    public class MarksManagment : IManagment<Mark>
    {
        private UnitOfWork unitOfWork { get; }

        public MarksManagment()
        {
            unitOfWork = new UnitOfWork("DefaultConnection");
        }

        public void Insert(Mark obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            unitOfWork.Marks.Insert(obj);
        }

        public void Update(Mark obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            unitOfWork.Marks.Update(obj);
        }

        public void Delete(Mark obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            unitOfWork.Marks.Delete(obj);
        }

        public void Load() => unitOfWork.Marks.Load();

        public IEnumerable<Mark> Find(Func<Mark, bool> predicate) => unitOfWork.Marks.Find(predicate);

        public Mark GetItem(int id) => unitOfWork.Marks.Get(id);

        public IEnumerable<Mark> GetList() => unitOfWork.Marks.GetAll();

        public void SaveChanges() => unitOfWork.SaveChanges();
    }
}
