namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rasp_2_b
    {
        public int? id_a_year { get; set; }

        public int? id_kafedra { get; set; }

        [StringLength(152)]
        public string t_fio { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string p32 { get; set; }

        public int? kol_b { get; set; }

        public int? kol_k { get; set; }

        [StringLength(300)]
        public string f1 { get; set; }

        [StringLength(10)]
        public string p20 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(300)]
        public string p34 { get; set; }

        [StringLength(100)]
        public string name_korpus { get; set; }

        [StringLength(20)]
        public string auditoria { get; set; }

        [StringLength(30)]
        public string WeekDay { get; set; }

        [StringLength(15)]
        public string Time_ { get; set; }

        public DateTime? beginDay { get; set; }

        public DateTime? endDay { get; set; }

        public int? id_teacher { get; set; }

        public int? id_rrnk { get; set; }

        [StringLength(50)]
        public string p42 { get; set; }
    }
}
