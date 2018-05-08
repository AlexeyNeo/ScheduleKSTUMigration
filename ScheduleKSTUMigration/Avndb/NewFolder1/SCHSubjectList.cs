namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SCHSubjectList")]
    public partial class SCHSubjectList
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_discipline { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(300)]
        public string p34 { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [StringLength(50)]
        public string code_discipline { get; set; }

        [StringLength(50)]
        public string rasp_code_discipline { get; set; }

        [StringLength(10)]
        public string s_p34 { get; set; }

        [StringLength(300)]
        public string p34_kg { get; set; }

        public int? plan_nag { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string SubjectShortName { get; set; }
    }
}
