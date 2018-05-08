namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCHScheduleList_a
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AcadYearID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string p32 { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool IsSemestrAutumn { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_w_s { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(24)]
        public string p42 { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WeekDayID { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(3)]
        public string WeekDayNameShort { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(20)]
        public string WeekDayName { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short PairNumber { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubGroup { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EveryWeek { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudyTypeID { get; set; }

        [StringLength(20)]
        public string StudyTypeName { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubjectID { get; set; }

        [StringLength(10)]
        public string s_p34 { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(300)]
        public string p34 { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(300)]
        public string SubjectName { get; set; }

        [StringLength(100)]
        public string SubjectShortName { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeID { get; set; }

        [StringLength(55)]
        public string FIO { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(152)]
        public string FullFIO { get; set; }

        public int? EmployeeID2 { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(55)]
        public string FIO2 { get; set; }

        public int? id_korpus { get; set; }

        [StringLength(100)]
        public string name_korpus { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AuditoryID { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(20)]
        public string AuditoryName { get; set; }

        public int? KafedraID { get; set; }

        [StringLength(50)]
        public string KafedraName { get; set; }

        [StringLength(300)]
        public string KafedraFullName { get; set; }

        public int? beg_nedeli { get; set; }

        public int? end_nedeli { get; set; }

        [Key]
        [Column(Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupID { get; set; }

        [StringLength(56)]
        public string GroupName { get; set; }

        [StringLength(250)]
        public string Groups { get; set; }

        [Key]
        [Column(Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [Key]
        [Column("p23-1", Order = 23)]
        [StringLength(50)]
        public string p23_1 { get; set; }

        [Key]
        [Column("p23-2", Order = 24)]
        [StringLength(100)]
        public string p23_2 { get; set; }

        [Key]
        [Column(Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_f_educ { get; set; }

        [Key]
        [Column(Order = 26)]
        [StringLength(100)]
        public string p108 { get; set; }
    }
}
