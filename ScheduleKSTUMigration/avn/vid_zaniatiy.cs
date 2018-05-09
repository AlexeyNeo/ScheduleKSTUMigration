namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vid_zaniatiy
    {
        [Key]
        public int id_vid_zaniatiy { get; set; }

        [StringLength(100)]
        public string name_vid_zaniatiy { get; set; }

        [StringLength(10)]
        public string polya { get; set; }

        [StringLength(50)]
        public string short_name { get; set; }

        public bool? For_rasp { get; set; }

        public bool? for_lms { get; set; }
    }
}
