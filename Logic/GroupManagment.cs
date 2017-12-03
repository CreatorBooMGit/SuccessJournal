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
    public class GroupManagment
    {
        public GroupContext groupContext;

        public GroupManagment()
        {
            groupContext = new GroupContext();
        }

        ~GroupManagment()
        {
            groupContext.Dispose();
        }

        public bool addStudent(Group p_group)
        {
            groupContext.groups.Add(p_group);

            return true;
        }

        public bool editStudent(Group p_group)
        {
            groupContext.groups.Attach(p_group);
            groupContext.Entry(p_group).State = EntityState.Modified;

            return true;
        }

        public bool removeStudent(Group p_group)
        {
            groupContext.groups.Remove(p_group);

            return true;
        }

        public bool refreshStudents()
        {
            groupContext.groups.Load();
            //groupContext.Students.Include("typesOfStudy").FirstOrDefault();
            return true;
        }

        public bool saveStudents()
        {
            groupContext.SaveChanges();

            return true;
        }

        public BindingList<Group> GetBindingList()
        {
            return groupContext.groups.Local.ToBindingList();
        }
    }
}
