namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVNtest_4
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_a_year { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string p32 { get; set; }

        public int? id_semester { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string p43 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [Key]
        [Column("p23-1", Order = 4)]
        [StringLength(50)]
        public string p23_1 { get; set; }

        public int? id_discipline { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(300)]
        public string p34 { get; set; }

        public int? id_examination { get; set; }

        [StringLength(50)]
        public string p30 { get; set; }

        public int? id_group { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }
    }
}
