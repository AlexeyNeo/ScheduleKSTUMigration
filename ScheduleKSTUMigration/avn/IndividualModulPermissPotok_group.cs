namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class IndividualModulPermissPotok_group
    {
        [Key]
        public int id_IndModulPermissPotok_group { get; set; }

        public int? id_a_year { get; set; }

        public int? id_w_s { get; set; }

        public int? id_faculty { get; set; }

        public int? id_semester { get; set; }

        public int? id_group { get; set; }

        public int? id_discipline { get; set; }

        public int? kredits { get; set; }

        public int? id_examination { get; set; }

        public int? id_ebe_var { get; set; }

        public int? id_f_e { get; set; }

        public int? id_modul { get; set; }

        public DateTime? begDate { get; set; }

        public DateTime? endDate { get; set; }

        public int? id_AVN_user { get; set; }

        public DateTime? AVN_log_date { get; set; }

        [StringLength(100)]
        public string host { get; set; }
    }
}
