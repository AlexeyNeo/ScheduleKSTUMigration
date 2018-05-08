namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rss")]
    public partial class rss
    {
        [Key]
        public int id_rsw { get; set; }

        public int? id_rate { get; set; }

        public int? id_semester { get; set; }

        public int? p_sem { get; set; }
    }
}
