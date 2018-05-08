namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCHScheduleList_old
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

        public int? KafedraID { get; set; }

        public int? beg_nedeli { get; set; }

        public int? end_nedeli { get; set; }

        public int? EmployeeID2 { get; set; }

        public DateTime? Sh_Date { get; set; }

        public int? id_time { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_Update { get; set; }

        [StringLength(150)]
        public string host { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(20)]
        public string AuditoryName { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(300)]
        public string SubjectName { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(20)]
        public string StudyTypeName { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(152)]
        public string FullFIO { get; set; }

        [StringLength(60)]
        public string FIO { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupID { get; set; }

        [StringLength(56)]
        public string GroupName { get; set; }

        [StringLength(250)]
        public string Groups { get; set; }
    }
}
