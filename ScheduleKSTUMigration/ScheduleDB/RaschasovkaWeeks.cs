namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RaschasovkaWeeks
    {
        public long Id { get; set; }

        public int RaschasovkaId { get; set; }

        public byte WeekId { get; set; }

        public virtual Raschasovka Raschasovka { get; set; }

        public virtual Week Week { get; set; }
    }
}
