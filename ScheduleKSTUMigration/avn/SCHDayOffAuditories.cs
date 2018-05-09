namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCHDayOffAuditories
    {
        public int ID { get; set; }

        public int AcadYearID { get; set; }

        public bool IsSemestrAutumn { get; set; }

        public int AuditoryID { get; set; }

        public int WeekDayID { get; set; }

        public short PairNumber { get; set; }

        public virtual Auditoriums Auditoriums { get; set; }
    }
}