namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_time
    {
        [Key]
        public int id_time { get; set; }

        [StringLength(15)]
        public string Time_ { get; set; }

        public int? sort { get; set; }

        public int? prov_time { get; set; }

        public int? vid_time { get; set; }
    }
}
