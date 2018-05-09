namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ModulPermiss")]
    public partial class ModulPermiss
    {
        [Key]
        public int id_modulPermiss { get; set; }

        public int? id_a_year { get; set; }

        public DateTime? begDate { get; set; }

        public DateTime? endDate { get; set; }

        public int? id_modul { get; set; }

        public int? id_semester { get; set; }

        public int? id_ebe_var { get; set; }

        public bool? forPotok { get; set; }

        public int? id_f_e { get; set; }

        public int id_f_educ { get; set; }
    }
}
