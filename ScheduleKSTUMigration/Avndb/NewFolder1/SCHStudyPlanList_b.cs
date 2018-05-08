namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCHStudyPlanList_b
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_educ_sh { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_speciality { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_a_year { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_semester { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kafedra { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_discipline { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_examination { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(4)]
        public string AVN_user { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(4)]
        public string AVN_update { get; set; }

        [StringLength(300)]
        public string kafedraName { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(300)]
        public string discipline { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(3)]
        public string examinationName { get; set; }

        [StringLength(357)]
        public string disciplineName { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sort { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(1)]
        public string SubjectShortName { get; set; }
    }
}
