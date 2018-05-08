namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temp_c
    {
        [Key]
        [Column("p23-1", Order = 0)]
        [StringLength(50)]
        public string p23_1 { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(77)]
        public string s_fio { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string p32 { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(30)]
        public string p43 { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(300)]
        public string p34 { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string p35 { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime p36 { get; set; }

        [StringLength(30)]
        public string oper { get; set; }

        public DateTime? u_date { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }
    }
}
