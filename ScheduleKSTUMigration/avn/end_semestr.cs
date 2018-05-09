namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class end_semestr
    {
        [Key]
        public int id_end_semestr { get; set; }

        public int? id_year { get; set; }

        public int? id_ws { get; set; }

        public DateTime? enddate { get; set; }
    }
}
