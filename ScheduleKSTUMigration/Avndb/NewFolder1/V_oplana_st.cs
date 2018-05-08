namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_oplana_st
    {
        public int? id_a_year { get; set; }

        public int? id_group { get; set; }

        public int? id_rate { get; set; }

        public int? id_student { get; set; }

        public double? sum_opl { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string p22 { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string p32 { get; set; }

        public double? p106 { get; set; }

        [StringLength(53)]
        public string sh_st { get; set; }

        [StringLength(454)]
        public string p25_2 { get; set; }

        public DateTime? come_date { get; set; }

        [StringLength(457)]
        public string spec { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(77)]
        public string s_fio { get; set; }

        public int? percent_privilege { get; set; }

        [StringLength(200)]
        public string privilege_coment { get; set; }

        public int? priv_var { get; set; }
    }
}
