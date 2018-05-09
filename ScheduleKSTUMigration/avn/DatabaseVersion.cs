namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DatabaseVersion")]
    public partial class DatabaseVersion
    {
        [Key]
        [StringLength(20)]
        public string DatabaseType { get; set; }

        [Required]
        [StringLength(50)]
        public string Version { get; set; }
    }
}
