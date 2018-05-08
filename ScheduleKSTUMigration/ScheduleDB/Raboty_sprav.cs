namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Raboty_sprav
    {
        [Key]
        public int Kod_rab { get; set; }

        [StringLength(50)]
        public string Naimenovanie_rabot { get; set; }
    }
}
