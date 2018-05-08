namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class test_DFS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_a_year { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string p32 { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_w_s { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(24)]
        public string p42 { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [Key]
        [Column("p23-1", Order = 5)]
        [StringLength(50)]
        public string p23_1 { get; set; }

        public int? id_semester { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(30)]
        public string p43 { get; set; }

        public int? id_group { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        public int? id_student { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(77)]
        public string s_fio { get; set; }

        public int? id_discipline { get; set; }

        [StringLength(374)]
        public string displin { get; set; }

        public int? id_teacher { get; set; }

        [StringLength(152)]
        public string t_fio { get; set; }
    }
}
