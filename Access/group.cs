using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Access
{
    [Table("groups")]
    public partial class Group
    {
        public Group()
        {
            studentsOfGroups = new List<StudentsOfGroups>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public int? course { get; set; }
        
        public virtual ICollection<StudentsOfGroups> studentsOfGroups { get; set; }
    }
}
