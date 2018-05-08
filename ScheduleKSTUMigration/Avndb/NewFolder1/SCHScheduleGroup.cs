namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCHScheduleGroup
    {
        public int ID { get; set; }

        public int ScheduleID { get; set; }

        public int GroupID { get; set; }

        public DateTime? AVN_Update { get; set; }

        [StringLength(150)]
        public string host { get; set; }

        public virtual SCHSchedule SCHSchedule { get; set; }
    }
}
