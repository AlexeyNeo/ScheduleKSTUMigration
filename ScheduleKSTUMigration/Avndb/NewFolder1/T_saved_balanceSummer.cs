namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_saved_balanceSummer
    {
        public int id { get; set; }

        public int id_year { get; set; }

        public int id_faculty { get; set; }

        public int id_rate { get; set; }

        public int sum { get; set; }

        [Column(TypeName = "date")]
        public DateTime AVN_date { get; set; }
    }
}
