namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RRNK_doljnost
    {
        [Key]
        public int id_rrnk_doljnost { get; set; }

        [StringLength(50)]
        public string n_doljnost { get; set; }

        public int? chasy { get; set; }

        public int? id_a_year { get; set; }
    }
}
