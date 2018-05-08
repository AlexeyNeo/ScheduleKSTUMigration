namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kassa")]
    public partial class Kassa
    {
        [Key]
        public int id_kassa { get; set; }

        [StringLength(20)]
        public string n_kassa { get; set; }

        [StringLength(50)]
        public string rukov { get; set; }

        [StringLength(50)]
        public string glavBuh { get; set; }

        [StringLength(50)]
        public string kasir { get; set; }

        [StringLength(50)]
        public string name { get; set; }
    }
}
