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
    public class JournalsManagment : IManagment<Journal>
    {
        private UnitOfWork unitOfWork { get; }

        public JournalsManagment()
        {
            unitOfWork = new UnitOfWork("DefaultConnection");
        }

        public void Insert(Journal obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            unitOfWork.Journals.Insert(obj);
        }

        public void Update(Journal obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            unitOfWork.Journals.Update(obj);
        }

        public void Delete(Journal obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            unitOfWork.Journals.Delete(obj);
        }

        public void Load() => unitOfWork.Journals.Load();

        public IEnumerable<Journal> Find(Func<Journal, bool> predicate) => unitOfWork.Journals.Find(predicate);

        public Journal GetItem(int id) => unitOfWork.Journals.Get(id);

        public IEnumerable<Journal> GetList() => unitOfWork.Journals.GetAll();

        public void SaveChanges() => unitOfWork.SaveChanges();
    }
}
