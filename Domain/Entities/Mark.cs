using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Domain
{
    [Table("Marks")]
    public class Mark
    {
        public int Id { get; set; }

        public int? JournalSubjectId { get; set; }
        public virtual JournalSubject JournalSubject { get; set; }

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
            
        public float Value { get; set; }
    }
}
