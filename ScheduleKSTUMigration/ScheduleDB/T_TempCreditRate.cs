namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_TempCreditRate
    {
        [Key]
        public long id_tempCreditRate { get; set; }

        public int id_creditRate { get; set; }
    }
}
