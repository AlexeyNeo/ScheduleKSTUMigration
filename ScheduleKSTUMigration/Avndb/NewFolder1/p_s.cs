namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("p-s")]
    public partial class p_s
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(77)]
        public string s_fio { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string p32 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string p22 { get; set; }

        [StringLength(53)]
        public string sh_st { get; set; }

        public double? p102 { get; set; }

        [Key]
        [Column(Order = 3)]
        public double p106 { get; set; }

        public double? razn { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }
    }
}
