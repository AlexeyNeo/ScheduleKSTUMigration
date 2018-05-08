namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class aud_discip_rasp
    {
        [Key]
        public int id_aud_discip_rasp { get; set; }

        public int? id_auditorium { get; set; }

        public int? id_discipline { get; set; }
    }
}
