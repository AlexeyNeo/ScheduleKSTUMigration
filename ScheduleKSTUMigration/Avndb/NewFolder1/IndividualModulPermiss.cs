namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IndividualModulPermiss")]
    public partial class IndividualModulPermiss
    {
        [Key]
        public int id_individualModulPermiss { get; set; }

        public int? id_teacher { get; set; }

        public int? id_group { get; set; }

        public int? id_discipline { get; set; }

        public int? id_a_year { get; set; }

        public DateTime? begDate { get; set; }

        public DateTime? endDate { get; set; }

        public int? id_modul { get; set; }

        public int? id_semester { get; set; }

        public int? id_ebe_var { get; set; }

        public int? id_f_e { get; set; }
    }
}
