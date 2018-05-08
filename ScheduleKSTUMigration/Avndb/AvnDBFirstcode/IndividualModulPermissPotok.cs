namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IndividualModulPermissPotok")]
    public partial class IndividualModulPermissPotok
    {
        [Key]
        public int id_IndividualModulPermissPotok { get; set; }

        public int? id_RRNKkrdt { get; set; }

        public int? id_teacher { get; set; }

        public int? id_year { get; set; }

        public int? id_discipline { get; set; }

        public int? id_modul { get; set; }

        public int? id_semester { get; set; }

        public DateTime? begDate { get; set; }

        public DateTime? endDate { get; set; }

        public int? vid_rrnk { get; set; }

        public int? id_rrnk_all { get; set; }

        public int? id_ebe_var { get; set; }

        public int? subgroup { get; set; }

        public int? id_f_e { get; set; }

        public int? id_w_s { get; set; }
    }
}
