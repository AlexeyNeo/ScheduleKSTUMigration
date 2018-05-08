namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tmp_special
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_special { get; set; }

        public int? id_direction { get; set; }

        [Column("p25-1")]
        [StringLength(50)]
        public string p25_1 { get; set; }

        [Column("p25-2")]
        [StringLength(300)]
        public string p25_2 { get; set; }

        public int? id_opl { get; set; }

        [StringLength(50)]
        public string standart { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public bool? visible { get; set; }
    }
}
