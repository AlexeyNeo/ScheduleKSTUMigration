namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class obrazovanie_teacher
    {
        [Key]
        public int id_obrazovanie_teacher { get; set; }

        public int? id_teacher { get; set; }

        public int? id_teacher_struktura { get; set; }

        public DateTime? Dates { get; set; }

        [StringLength(100)]
        public string Number { get; set; }

        public int? id_teacher_stepen { get; set; }

        public int? id_user { get; set; }

        public DateTime? AVN_date { get; set; }
    }
}
