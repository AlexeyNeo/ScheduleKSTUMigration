namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_DisciplineForStudentPermissions
    {
        [Key]
        public int id_disciplineForStudentPermission { get; set; }

        public int id_a_year { get; set; }

        public int id_w_s { get; set; }

        public int id_faculty { get; set; }

        public int o_z { get; set; }

        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }
    }
}
