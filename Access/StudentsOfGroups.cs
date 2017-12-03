using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Access
{
    [Table("students_of_groups")]
    public partial class StudentsOfGroups
    {
        public int id { get; set; }

        public int group_id { get; set; }

        public int student_id { get; set; }

        public int order_in_group { get; set; }

        public virtual Group group { get; set; }

        public virtual Student student { get; set; }
    }
}
