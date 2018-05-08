namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_EventMessages
    {
        [Key]
        public long id_eventMessage { get; set; }

        public int id_faculty { get; set; }

        public int id_human { get; set; }

        public int id_humanType { get; set; }

        [Required]
        public string message { get; set; }

        [Required]
        [StringLength(255)]
        public string fileName { get; set; }

        public DateTime created { get; set; }

        public bool isDeleted { get; set; }

        public int order { get; set; }

        public int id_humanTypeFor { get; set; }

        public bool isForLeftSide { get; set; }
    }
}
