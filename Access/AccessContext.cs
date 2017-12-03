using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Access
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("DefaultConnection")
        {

        }
        
        public DbSet<Student> students { get; set; }
    }

    public class TypesOfStudyContext : DbContext
    {
        public TypesOfStudyContext() : base("DefaultConnection")
        {

        }

        public DbSet<TypesOfStudy> typesOfStudy { get; set; }
    }

    public class TypesPayStudyContext : DbContext
    {
        public TypesPayStudyContext() : base("DefaultConnection")
        {

        }

        public DbSet<TypesPayStudy> typesPayStudy { get; set; }
    }

    public class GroupContext : DbContext
    {
        public GroupContext() : base("DefaultConnection")
        {

        }

        public DbSet<Group> groups { get; set; }
    }
}
