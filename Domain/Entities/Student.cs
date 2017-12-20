using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Domain
{
    [Table("Students")]
    public class Student
    {
        public int Id { get; set; }
        
        public string Fullname { get; set; }

        public int? GroupId { get; set; }

        public virtual Group Group { get; set; }
    }
}
