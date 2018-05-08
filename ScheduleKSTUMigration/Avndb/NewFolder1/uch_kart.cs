namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class uch_kart
    {
        [StringLength(56)]
        public string p20 { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(70)]
        public string v2 { get; set; }

        [Key]
        [Column("p23-2", Order = 1)]
        [StringLength(100)]
        public string p23_2 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(70)]
        public string mo { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(77)]
        public string s_fio { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_student { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(15)]
        public string name { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string p108 { get; set; }

        [StringLength(15)]
        public string idid { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_group { get; set; }

        [StringLength(53)]
        public string sh_st { get; set; }
    }
}
