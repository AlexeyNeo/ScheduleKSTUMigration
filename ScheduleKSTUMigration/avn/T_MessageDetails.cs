namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_MessageDetails
    {
        [Key]
        public int id_messageDetails { get; set; }

        public int id_message { get; set; }

        public int id_humanTo { get; set; }

        public int id_humanTypeTo { get; set; }

        public bool read { get; set; }

        public int id_group { get; set; }
    }
}
