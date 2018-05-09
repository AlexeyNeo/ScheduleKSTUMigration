namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IndividualModulPermissGROUP")]
    public partial class IndividualModulPermissGROUP
    {
        [Key]
        public int id_IndividualModulPermissGROUP { get; set; }

        public int? id_group { get; set; }

        public int? id_a_year { get; set; }

        public int? id_semester { get; set; }

        public DateTime? beg_date { get; set; }

        public DateTime? end_date { get; set; }

        public int? id_modul { get; set; }

        public int? id_f_e { get; set; }

        public int? id_ebe_var { get; set; }

        public int? id_AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [StringLength(250)]
        public string host { get; set; }
    }
}
