namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IndividualModulPermissByFuckulty")]
    public partial class IndividualModulPermissByFuckulty
    {
        [Key]
        public int id_individualModulPermissByFuckulty { get; set; }

        public int? id_faculty { get; set; }

        public int? id_a_year { get; set; }

        public int? id_semester { get; set; }

        public int? id_modul { get; set; }

        public DateTime? begDate { get; set; }

        public DateTime? endDate { get; set; }

        public int? id_f_educ { get; set; }

        public int? id_ebe_var { get; set; }

        public int? id_f_e { get; set; }
    }
}
