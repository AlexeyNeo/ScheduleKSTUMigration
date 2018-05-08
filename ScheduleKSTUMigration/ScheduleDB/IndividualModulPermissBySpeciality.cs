namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IndividualModulPermissBySpeciality")]
    public partial class IndividualModulPermissBySpeciality
    {
        [Key]
        public int id_IndividualModulPermissBySpeciality { get; set; }

        public int id_speciality { get; set; }

        public int id_a_year { get; set; }

        public int id_semester { get; set; }

        public int id_modul { get; set; }

        public DateTime begDate { get; set; }

        public DateTime endDate { get; set; }

        public int id_ebe_var { get; set; }

        public int id_f_e { get; set; }
    }
}
