using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Access
{
    [Table("typesPayStudy")]
    public partial class TypesPayStudy
    {
        public TypesPayStudy()
        {
            students = new HashSet<Student>();
        }

        public int id { get; set; }

        [StringLength(50)]
        public string name { get; set; }
        
        public virtual ICollection<Student> students { get; set; }
    }
}
