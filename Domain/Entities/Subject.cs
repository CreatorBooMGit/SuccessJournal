using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Domain
{
    [Table("Subjects")]
    public class Subject
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

        public virtual ICollection<JournalSubject> JournalSubjects { get; set; }
    }
}
