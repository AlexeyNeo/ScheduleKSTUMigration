namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ScheduleAdditionalGroups
    {
        [Key]
        public int id_scheduleAdditionalGroup { get; set; }

        public int id_rrnk { get; set; }

        public int id_group { get; set; }

        public int id_teacher { get; set; }

        public int id_a_year { get; set; }

        public int id_w_s { get; set; }

        public int? id_vidZanyatiy { get; set; }

        public int? id_discipline { get; set; }

        public int? kredit { get; set; }

        public int? id_day { get; set; }
    }
}
