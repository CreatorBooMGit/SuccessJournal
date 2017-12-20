using Access.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Access.Repositories;

namespace Access
{
    public class UnitOfWork : IUnitOfWork
    {
        private AccessContext accessContext;
        private GroupsRepository groupsRepository;
        private JournalsRepository journalsRepository;
        private JournalsSubjectRepository journalsSubjectRepository;
        private MarksRepository marksRepository;
        private StudentsRepository studentsRepository;
        private SubjectsRepository subjectsRepository;
        private TeachersRepository teachersRepository;

        public UnitOfWork(string connectionString)
        {
            accessContext = new AccessContext(connectionString);
        }

        ~UnitOfWork()
        {
            Dispose(false);
        }

        public IRepository<Group> Groups
        {
            get
            {
                if (groupsRepository == null)
                    groupsRepository = new GroupsRepository(accessContext);

                return groupsRepository;
            }
        }

        public IRepository<Journal> Journals
        {
            get
            {
                if (journalsRepository == null)
                    journalsRepository = new JournalsRepository(accessContext);

                return journalsRepository;
            }
        }


        public IRepository<JournalSubject> JournalsSubject
        {
            get
            {
                if (journalsSubjectRepository == null)
                    journalsSubjectRepository = new JournalsSubjectRepository(accessContext);

                return journalsSubjectRepository;
            }
        }

        public IRepository<Mark> Marks
        {
            get
            {
                if (marksRepository == null)
                    marksRepository = new MarksRepository(accessContext);

                return marksRepository;
            }
        }

        public IRepository<Student> Students
        {
            get
            {
                if (studentsRepository == null)
                    studentsRepository = new StudentsRepository(accessContext);

                return studentsRepository;
            }
        }

        public IRepository<Subject> Subjects
        {
            get
            {
                if (subjectsRepository == null)
                    subjectsRepository = new SubjectsRepository(accessContext);

                return subjectsRepository;
            }
        }

        public IRepository<Teacher> Teachers
        {
            get
            {
                if (teachersRepository == null)
                    teachersRepository = new TeachersRepository(accessContext);

                return teachersRepository;
            }
        }

        public void SaveChanges()
        {
            accessContext.SaveChanges();
        }

        #region IDisposable Support


        private bool disposedValue = false; // Для определения избыточных вызовов
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    accessContext.Dispose();
                }

                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
