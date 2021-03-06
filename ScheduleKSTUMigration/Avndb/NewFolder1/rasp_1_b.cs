namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rasp_1_b
    {
        public int? id_a_year { get; set; }

        public int? id_kafedra { get; set; }

        [StringLength(152)]
        public string t_fio { get; set; }

        [StringLength(300)]
        public string f1 { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string p32 { get; set; }

        public int? id_teacher { get; set; }

        public int? kol_b { get; set; }

        public int? kol_k { get; set; }

        [StringLength(10)]
        public string p20 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(300)]
        public string p34 { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_rrnkKrdt { get; set; }

        [StringLength(50)]
        public string p42 { get; set; }
    }
}
