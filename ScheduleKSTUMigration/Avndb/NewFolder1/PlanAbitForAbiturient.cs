namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanAbitForAbiturient")]
    public partial class PlanAbitForAbiturient
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_plan_abit { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_speciality { get; set; }

        public int? id_a_year { get; set; }

        public int? IDLicence { get; set; }

        public int? id_standard { get; set; }

        public int? id_qualification { get; set; }

        [StringLength(20)]
        public string code_spec { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public double? Apprenticeship { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kol_k { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kol_b { get; set; }
    }
}
