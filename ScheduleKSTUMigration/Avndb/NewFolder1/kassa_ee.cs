namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kassa_ee
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kassa { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime p103 { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int p104 { get; set; }

        [StringLength(20)]
        public string p104_1 { get; set; }

        [StringLength(80)]
        public string e_uslugi { get; set; }

        public double? e_p102 { get; set; }

        public int? id_a_year { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string ab_fio { get; set; }

        [StringLength(152)]
        public string t_fio { get; set; }

        [StringLength(77)]
        public string s_fio { get; set; }

        [StringLength(100)]
        public string dopol { get; set; }

        public int? id_speciality { get; set; }

        public int? id_faculty { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_v_opl { get; set; }
    }
}
