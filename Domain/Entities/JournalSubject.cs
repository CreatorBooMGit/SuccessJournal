using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Domain
{
    [Table("JournalsSubject")]
    public class JournalSubject
    {
        public int Id { get; set; }

        public int? SubjectId { get; set; }
        public virtual Subject Subject { get; set; }

        public virtual ICollection<Mark> Marks { get; set; }
    }
}
