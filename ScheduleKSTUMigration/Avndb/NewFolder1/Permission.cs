namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Permission
    {
        [Key]
        public string name { get; set; }

        [StringLength(128)]
        public string Owner { get; set; }

        [StringLength(31)]
        public string Object_type { get; set; }
    }
}
