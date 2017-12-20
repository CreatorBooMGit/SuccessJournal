using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Domain
{
    [Table("Groups")]
    public class Group
    {
        public Group()
        {
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        public int Course { get; set; }
        
        public Journal Journal { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
