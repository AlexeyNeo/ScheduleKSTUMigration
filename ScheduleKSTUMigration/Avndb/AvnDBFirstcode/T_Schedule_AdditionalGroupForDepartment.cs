namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Schedule_AdditionalGroupForDepartment
    {
        [Key]
        public int id_schedule_additionalGroupForDepartment { get; set; }

        public int id_a_year { get; set; }

        public int id_w_s { get; set; }

        public int id_discipline { get; set; }

        public int kredits { get; set; }

        public int id_kafedra { get; set; }

        public int id_group { get; set; }

        public int id_day { get; set; }
    }
}
