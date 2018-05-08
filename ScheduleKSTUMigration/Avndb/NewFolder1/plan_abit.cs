namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class plan_abit
    {
        [Key]
        public int id_plan_abit { get; set; }

        public int id_speciality { get; set; }

        [StringLength(20)]
        public string code_spec { get; set; }

        public int? id_a_year { get; set; }

        public int kol_k { get; set; }

        public int kol_b { get; set; }

        public int? IDLicence { get; set; }

        public double? Apprenticeship { get; set; }

        public int? id_standard { get; set; }

        public int? id_qualification { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_date { get; set; }

        public virtual a_year a_year { get; set; }

        public virtual com_sfe com_sfe { get; set; }
    }
}
