namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Department")]
    public partial class Department
    {
        [Key]
        public int IDDepartment { get; set; }

        public short Faculties { get; set; }

        [Required]
        [StringLength(60)]
        public string NameDepartment { get; set; }

        [Required]
        [StringLength(10)]
        public string SmallNameDepartment { get; set; }

        [Required]
        [StringLength(10)]
        public string CodeDepartment { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }
    }
}
