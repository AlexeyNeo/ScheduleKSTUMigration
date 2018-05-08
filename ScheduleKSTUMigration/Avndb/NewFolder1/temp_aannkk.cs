namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temp_aannkk
    {
        public int? id_faculty { get; set; }

        [Key]
        [Column("p23-1")]
        [StringLength(50)]
        public string p23_1 { get; set; }

        public int? kol_stud { get; set; }

        public int? kol_reg_disc { get; set; }

        public int? kol_cdal_disc { get; set; }

        public int? sdal_anket { get; set; }
    }
}
