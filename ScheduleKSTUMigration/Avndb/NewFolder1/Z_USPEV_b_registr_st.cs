namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Z_USPEV_b_registr_st
    {
        public int? id_a_year { get; set; }

        public int? id_semester { get; set; }

        public int? id_student { get; set; }

        public int? id_group { get; set; }

        public int? id_discipline { get; set; }

        public int? id_examination { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Krdt { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UP { get; set; }
    }
}
