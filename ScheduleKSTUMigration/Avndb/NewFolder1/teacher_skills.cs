namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class teacher_skills
    {
        [Key]
        public int id_teacher_skills { get; set; }

        [StringLength(500)]
        public string personal_skills { get; set; }

        [StringLength(500)]
        public string computer_skills { get; set; }

        [StringLength(500)]
        public string other_info { get; set; }

        public int id_teacher { get; set; }
    }
}
