namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_Raspisanie_new
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_a_year { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string p32 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_w_s { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int day_number { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(3)]
        public string Day_name { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_time { get; set; }

        [StringLength(15)]
        public string Time_ { get; set; }

        public int? sort { get; set; }

        public int? vid_time { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubGroup { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EveryWeek { get; set; }

        [StringLength(5)]
        public string ch_zham { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudyTypeID { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(20)]
        public string StudyTypeName { get; set; }

        public int? id_teacher { get; set; }

        [StringLength(55)]
        public string s_t_fio { get; set; }

        public int? id_auditorium { get; set; }

        [StringLength(20)]
        public string number { get; set; }

        public int? id_kafedra { get; set; }

        [StringLength(50)]
        public string sn_f1 { get; set; }

        public int? beg_nedeli { get; set; }

        public int? end_nedeli { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_group { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [Key]
        [Column("p23-1", Order = 13)]
        [StringLength(50)]
        public string p23_1 { get; set; }

        [Key]
        [Column("p23-2", Order = 14)]
        [StringLength(100)]
        public string p23_2 { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_rate { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(50)]
        public string p22 { get; set; }

        public int? EmployeeID2 { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_discipline { get; set; }

        [StringLength(300)]
        public string p34 { get; set; }

        public DateTime? Sh_Date { get; set; }

        [StringLength(300)]
        public string p34_kg { get; set; }
    }
}
