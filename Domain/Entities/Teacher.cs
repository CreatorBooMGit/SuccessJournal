using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Domain
{
    [Table("Teachers")]
    public class Teacher
    {
        public int Id { get; set; }

        public string Fullname { get; set; }

        public virtual ICollection<Subject> Subjects { get; set; }
    }
}
