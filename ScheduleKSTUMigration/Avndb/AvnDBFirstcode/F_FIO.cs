namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F_FIO
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_teacher { get; set; }

        [Column("F_FIO")]
        [StringLength(92)]
        public string F_FIO1 { get; set; }

        public int? id_family_s { get; set; }

        [Key]
        [Column(Order = 1)]
        public int id_family { get; set; }

        public int? Old { get; set; }
    }
}
