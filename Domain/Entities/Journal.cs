using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Domain
{
    [Table("Journals")]
    public class Journal
    {
        public int Id { get; set; }
        
        public virtual Group Group { get; set; }

        public virtual ICollection<JournalSubject> JournalSubject { get; set; }
    }
}
