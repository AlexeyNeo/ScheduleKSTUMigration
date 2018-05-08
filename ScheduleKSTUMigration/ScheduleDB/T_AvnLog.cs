namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_AvnLog
    {
        [Key]
        public long id_avnLog { get; set; }

        public int id_human { get; set; }

        public int id_humanType { get; set; }

        public int id_logAction { get; set; }

        [Required]
        [StringLength(255)]
        public string tableName { get; set; }

        [Required]
        [StringLength(255)]
        public string fieldName { get; set; }

        public long id_key { get; set; }

        [Required]
        public string logMessage { get; set; }

        public DateTime created { get; set; }
    }
}
