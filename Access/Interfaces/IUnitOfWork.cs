using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Group> Groups { get; }
        IRepository<Journal> Journals { get; }
        IRepository<JournalSubject> JournalsSubject { get; }
        IRepository<Mark> Marks { get; }
        IRepository<Student> Students { get; }
        IRepository<Subject> Subjects { get; }
        IRepository<Teacher> Teachers { get; }
        void SaveChanges();
    }
}
