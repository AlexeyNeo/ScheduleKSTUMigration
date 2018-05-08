namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Abit_Log
    {
        [Key]
        public int id_abit_log { get; set; }

        [StringLength(20)]
        public string table { get; set; }

        public int row_id { get; set; }

        [Column(TypeName = "ntext")]
        public string descr { get; set; }

        [StringLength(50)]
        public string comp { get; set; }

        [StringLength(20)]
        public string AVN_User { get; set; }

        public DateTime? AVN_Update { get; set; }
    }
}
