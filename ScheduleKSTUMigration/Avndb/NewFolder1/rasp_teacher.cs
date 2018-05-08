namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rasp_teacher
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_shcedule { get; set; }

        public int? id_year { get; set; }

        [StringLength(10)]
        public string p32 { get; set; }

        public int? u_god { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_w_s { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(24)]
        public string p42 { get; set; }

        public int? id_discipline { get; set; }

        [StringLength(300)]
        public string p34 { get; set; }

        public int? kredit { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(100)]
        public string name_korpus { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_auditorium { get; set; }

        [StringLength(20)]
        public string number { get; set; }

        public int? num_nedeli { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_day { get; set; }

        [StringLength(10)]
        public string briefName { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_time { get; set; }

        [StringLength(15)]
        public string Time_ { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_teacher { get; set; }

        [StringLength(152)]
        public string t_fio { get; set; }

        public int? id_rrnk { get; set; }

        public int? id_rrnkKrdt { get; set; }

        public byte? subgroup { get; set; }

        public byte? rrnkType { get; set; }

        [StringLength(100)]
        public string name_vid_zaniatiy { get; set; }

        public int? id_group { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        public int? id_vid_zaniatiy { get; set; }
    }
}
