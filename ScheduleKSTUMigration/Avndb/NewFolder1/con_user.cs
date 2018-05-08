namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class con_user
    {
        [StringLength(128)]
        public string user { get; set; }

        [Key]
        [StringLength(10)]
        public string db_user { get; set; }
    }
}
