namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class shetchik_avn10_report
    {
        [Key]
        public int id_shetchik { get; set; }

        public bool? znak_pechat { get; set; }

        public DateTime? udate { get; set; }
    }
}
