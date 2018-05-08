namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Abit_razryd_sport
    {
        [Key]
        public int id_abit_razryd_sport { get; set; }

        public int? id_abit { get; set; }

        public int? id_abit_razryd { get; set; }

        [StringLength(250)]
        public string AVN_log { get; set; }

        public DateTime AVN_date { get; set; }

        [StringLength(250)]
        public string Host { get; set; }
    }
}
