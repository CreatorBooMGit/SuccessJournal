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
    public class JournalsSubjectManagment : IManagment<JournalSubject>
    {
        private UnitOfWork unitOfWork { get; }

        public JournalsSubjectManagment()
        {
            unitOfWork = new UnitOfWork("DefaultConnection");
        }

        public void Insert(JournalSubject obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            unitOfWork.JournalsSubject.Insert(obj);
        }

        public void Update(JournalSubject obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            unitOfWork.JournalsSubject.Update(obj);
        }

        public void Delete(JournalSubject obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            unitOfWork.JournalsSubject.Delete(obj);
        }

        public void Load() => unitOfWork.JournalsSubject.Load();

        public IEnumerable<JournalSubject> Find(Func<JournalSubject, bool> predicate) => unitOfWork.JournalsSubject.Find(predicate);

        public JournalSubject GetItem(int id) => unitOfWork.JournalsSubject.Get(id);

        public IEnumerable<JournalSubject> GetList() => unitOfWork.JournalsSubject.GetAll();

        public void SaveChanges() => unitOfWork.SaveChanges();
    }
}
