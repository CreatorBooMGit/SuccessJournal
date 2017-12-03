using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel;
using Access;

namespace Logic
{
    public class StudentManagment
    {
        public StudentContext studentContext;

        public StudentManagment()
        {
            studentContext = new StudentContext();
        }

        ~StudentManagment()
        {
            studentContext.Dispose();
        }

        public bool addStudent(Student p_student)
        {
            studentContext.students.Add(p_student);

            return true;
        }

        public bool editStudent(Student p_student)
        {
            studentContext.students.Attach(p_student);
            studentContext.Entry(p_student).State = EntityState.Modified;

            return true;
        }

        public bool removeStudent(Student p_student)
        {
            studentContext.students.Remove(p_student);

            return true;
        }

        public bool refreshStudents()
        {
            studentContext.students.Load();
            //studentContext.Students.Include("typesOfStudy").FirstOrDefault();
            return true;
        }

        public bool saveStudents()
        {
            studentContext.SaveChanges();

            return true;
        }

        public BindingList<Student> GetBindingList()
        {
            return studentContext.students.Local.ToBindingList();
        }
    }
}
