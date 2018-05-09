namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SCHSchedule")]
    public partial class SCHSchedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SCHSchedule()
        {
            SCHScheduleGroups = new HashSet<SCHScheduleGroups>();
        }

        public int ID { get; set; }

        public int AcadYearID { get; set; }

        public bool IsSemestrAutumn { get; set; }

        public int WeekDayID { get; set; }

        public short PairNumber { get; set; }

        public int SubGroup { get; set; }

        public int EveryWeek { get; set; }

        public int StudyTypeID { get; set; }

        public int SubjectID { get; set; }

        public int EmployeeID { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCHScheduleGroups> SCHScheduleGroups { get; set; }

        public virtual SCHStudyType SCHStudyType { get; set; }
    }
}
