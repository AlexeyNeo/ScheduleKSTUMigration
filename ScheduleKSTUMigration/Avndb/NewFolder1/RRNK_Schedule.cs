namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RRNK_Schedule
    {
        [Key]
        public int id_RRNK_Schedule { get; set; }

        public int? vid_rrnk { get; set; }

        public int? id_rrnk_krdt { get; set; }

        public int? id_auditorium { get; set; }

        public int? id_day { get; set; }

        public int? id_time { get; set; }

        public int? id_korpus { get; set; }

        public DateTime? beginDay { get; set; }

        public DateTime? endDay { get; set; }

        public int? id_rrnk_all { get; set; }
    }
}
