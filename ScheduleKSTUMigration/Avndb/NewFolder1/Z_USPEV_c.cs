namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Z_USPEV_c
    {
        public int? id_group { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_student { get; set; }

        public int? id_semester { get; set; }

        public int? id_discipline { get; set; }

        public int? id_examination { get; set; }

        public double? ball { get; set; }

        public bool? isStaticDiscipline { get; set; }

        public int? id_estimation { get; set; }

        public int? id_mark_mag { get; set; }

        public int? kredits { get; set; }

        public int? UP { get; set; }

        public DateTime? p36 { get; set; }

        public int? id_f_est { get; set; }
    }
}
