namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Experience")]
    public partial class Experience
    {
        [Key]
        public int id_experience { get; set; }

        [StringLength(30)]
        public string specialty { get; set; }

        public double? Gov_Service { get; set; }

        public double? On_Owners { get; set; }

        public double? specialty_s { get; set; }

        public double? Total_s { get; set; }

        public double? Unbreakable { get; set; }

        public int? id_teacher { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public double? teacher_s { get; set; }

        public DateTime? Total_sDate { get; set; }

        public DateTime? teacher_sDate { get; set; }

        [StringLength(10)]
        public string vis_gor { get; set; }

        public virtual teacher teacher { get; set; }
    }
}
