namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_SchoolClasses
    {
        [Key]
        public long id_schoolClass { get; set; }

        public int id_schoolTeacher { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }
    }
}
