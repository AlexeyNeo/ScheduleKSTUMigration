namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_MYFIND
    {
        [StringLength(30)]
        public string table { get; set; }

        [Column(TypeName = "ntext")]
        public string descr { get; set; }

        [StringLength(20)]
        public string AVN_User { get; set; }

        public DateTime? AVN_Update { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(77)]
        public string s_fio { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(300)]
        public string p34 { get; set; }

        [StringLength(50)]
        public string p30 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string p43 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_mark_mag { get; set; }

        [Column("Estimateon - On")]
        [StringLength(4000)]
        public string Estimateon___On { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }
    }
}
