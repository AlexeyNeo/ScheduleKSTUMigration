namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rrnkPermiss")]
    public partial class rrnkPermiss
    {
        [Key]
        public int id_rrnkPermiss { get; set; }

        public int? id_a_year { get; set; }

        public int? id_kafedra { get; set; }

        public DateTime? begDate { get; set; }

        public DateTime? endDate { get; set; }
    }
}
