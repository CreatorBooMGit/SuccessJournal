using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Domain;

namespace Access
{
    public class AccessContext : DbContext
    {
        public AccessContext(string connectString) : base(connectString)
        {
            Database.SetInitializer<AccessContext>(new DropCreateDatabaseIfModelChanges<AccessContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Journal>().HasRequired(x => x.Group).WithRequiredDependent(x => x.Journal).Map(c => c.MapKey("GroupId"));
        }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Journal> Journals { get; set; }
        public DbSet<JournalSubject> JournalsSubject { get; set; }
        public DbSet<Mark> Marks { get; set; }
    }
}
