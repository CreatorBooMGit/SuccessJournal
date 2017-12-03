using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Access
{
    [Table("students")]
    public partial class Student
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string surname { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string patronymic { get; set; }

        [Column(TypeName = "date")]
        public DateTime? birthday { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_receipt { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date_issue { get; set; }

        public virtual TypesOfStudy typesOfStudy { get; set; }

        public virtual TypesPayStudy typesPayStudy { get; set; }
    }
}
