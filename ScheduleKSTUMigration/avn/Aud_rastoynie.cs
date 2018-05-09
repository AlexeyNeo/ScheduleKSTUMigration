namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Aud_rastoynie
    {
        [Key]
        public int id_aud_rastoynie { get; set; }

        public int? id_auditorium_owner { get; set; }

        public int? id_auditorium { get; set; }

        public float rastoynie { get; set; }

        public int id_korpus { get; set; }
    }
}
