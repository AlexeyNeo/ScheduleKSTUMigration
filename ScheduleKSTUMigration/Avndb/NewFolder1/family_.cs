namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class family_
    {
        [Key]
        public int id_family { get; set; }

        public int? id_family_status { get; set; }

        public int? id_family_s { get; set; }

        public DateTime? Date_of_birth { get; set; }

        [StringLength(50)]
        public string Address { get; set; }

        public int? id_family_job { get; set; }

        [StringLength(50)]
        public string Org_Address { get; set; }

        public int id_teacher { get; set; }

        [StringLength(30)]
        public string p26 { get; set; }

        [StringLength(30)]
        public string p27 { get; set; }

        [StringLength(30)]
        public string p28 { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public virtual family family { get; set; }

        public virtual Family_s Family_s { get; set; }

        public virtual Family_spec Family_spec { get; set; }

        public virtual teacher teacher { get; set; }
    }
}
