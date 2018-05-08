namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Abit_sostav_priem
    {
        [Key]
        public int id_sostav { get; set; }

        [StringLength(100)]
        public string FIO { get; set; }

        [StringLength(100)]
        public string Doljnost { get; set; }

        public int? Sort { get; set; }
    }
}
