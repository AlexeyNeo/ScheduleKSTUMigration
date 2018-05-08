namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SCHScheduleList")]
    public partial class SCHScheduleList
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
        public bool IsSemestrAutumn { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int WeekDayID { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short PairNumber { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubGroup { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EveryWeek { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudyTypeID { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SubjectID { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeID { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AuditoryID { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(20)]
        public string AuditoryName { get; set; }

        [StringLength(689)]
        public string SubjectName { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(20)]
        public string StudyTypeName { get; set; }

        [StringLength(152)]
        public string FullFIO { get; set; }

        [StringLength(111)]
        public string FIO { get; set; }

        public int? EmployeeID2 { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(55)]
        public string FIO2 { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupID { get; set; }

        [StringLength(56)]
        public string GroupName { get; set; }

        [StringLength(250)]
        public string Groups { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_w_s { get; set; }

        public int? KafedraID { get; set; }

        [StringLength(50)]
        public string KafedraName { get; set; }

        [StringLength(300)]
        public string KafedraFullName { get; set; }

        public int? beg_nedeli { get; set; }

        public int? end_nedeli { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_time { get; set; }

        public DateTime? Date { get; set; }
    }
}
