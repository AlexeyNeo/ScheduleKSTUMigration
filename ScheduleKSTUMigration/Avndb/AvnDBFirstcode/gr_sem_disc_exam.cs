namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class gr_sem_disc_exam
    {
        public int? id_group { get; set; }

        public int? id_semester { get; set; }

        public int? id_discipline { get; set; }

        public int? id_examination { get; set; }

        [StringLength(337)]
        public string p34 { get; set; }

        [StringLength(50)]
        public string p30 { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kpv { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Kredits { get; set; }
    }
}
