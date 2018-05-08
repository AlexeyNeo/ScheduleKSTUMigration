namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Holiday")]
    public partial class Holiday
    {
        [Key]
        public int id_vacation { get; set; }

        public int? id_teacher { get; set; }

        public int? id_vacation_t { get; set; }

        public DateTime? from_d { get; set; }

        public DateTime? to_d { get; set; }

        public DateTime? Date_begin { get; set; }

        public DateTime? Date_End { get; set; }

        public int? n_days { get; set; }

        [StringLength(10)]
        public string n_prikaz { get; set; }

        public DateTime? date_prikaz { get; set; }

        public DateTime? otz_from_d { get; set; }

        [StringLength(10)]
        public string otz_prik { get; set; }

        public DateTime? otz_pr_date { get; set; }

        public int? not_used_days { get; set; }

        public int? not_used_pay_days { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public virtual Holliday_t Holliday_t { get; set; }

        public virtual teacher teacher { get; set; }
    }
}
