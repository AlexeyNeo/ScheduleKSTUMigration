namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class R_4
    {
        public int? kol_teacher { get; set; }

        public int? id_discipline { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kredit { get; set; }

        public int? id_a_year { get; set; }

        public int? id_w_s { get; set; }
    }
}
