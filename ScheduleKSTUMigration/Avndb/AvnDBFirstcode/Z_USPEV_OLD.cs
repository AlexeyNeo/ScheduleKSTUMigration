namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Z_USPEV_OLD
    {
        public int? id_group { get; set; }

        [Key]
        [Column(Order = 0)]
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

        [Key]
        [Column(Order = 1)]
        [StringLength(300)]
        public string p34 { get; set; }
    }
}
