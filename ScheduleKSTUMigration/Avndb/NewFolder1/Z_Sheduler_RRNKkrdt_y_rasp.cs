namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Z_Sheduler_RRNKkrdt_y_rasp
    {
        public int? id_year { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string p32 { get; set; }

        public int? id_ws { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(24)]
        public string p42 { get; set; }

        public int? id_semester { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string p43 { get; set; }

        public int? id_faculty { get; set; }

        [Key]
        [Column("p23-1", Order = 3)]
        [StringLength(50)]
        public string p23_1 { get; set; }

        [Key]
        [Column("p23-2", Order = 4)]
        [StringLength(100)]
        public string p23_2 { get; set; }

        public int? id_speciality { get; set; }

        [StringLength(454)]
        public string p25_2 { get; set; }

        public int? day_number { get; set; }

        [StringLength(10)]
        public string Day_name { get; set; }

        public int? id_time { get; set; }

        [StringLength(15)]
        public string Time_ { get; set; }

        public int? b_num_nedeli { get; set; }

        public int? e_num_nedeli { get; set; }

        public int? id_auditorium { get; set; }

        [StringLength(20)]
        public string aud_num { get; set; }

        public int? id_rrnk { get; set; }

        public int? id_discipline { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(300)]
        public string p34 { get; set; }

        public int? kredit { get; set; }

        public int? id_kafedra { get; set; }

        [StringLength(300)]
        public string f1 { get; set; }

        public int? id_teacher { get; set; }

        [StringLength(55)]
        public string s_t_fio { get; set; }

        public byte? subgroup { get; set; }

        public int? id_vid_zaniatiy { get; set; }

        [StringLength(50)]
        public string short_name { get; set; }

        [StringLength(100)]
        public string name_vid_zaniatiy { get; set; }

        public int? id_teacherOwner { get; set; }

        public int? id_teacherOwner1 { get; set; }
    }
}
