namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kass_ab
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int p { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kassa { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime p103 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int p104 { get; set; }

        [StringLength(100)]
        public string p104_1 { get; set; }

        [StringLength(80)]
        public string uslugi { get; set; }

        public double? p102 { get; set; }

        public int? id_a_year { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        [StringLength(152)]
        public string ab_fio { get; set; }

        [StringLength(152)]
        public string t_fio { get; set; }

        [StringLength(100)]
        public string dopol { get; set; }

        public int? id_speciality { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [StringLength(20)]
        public string sl_group { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_v_opl { get; set; }
    }
}
