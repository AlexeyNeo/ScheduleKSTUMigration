namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KasFak")]
    public partial class KasFak
    {
        [Key]
        public int id_kas_fak { get; set; }

        public int? id_kassa { get; set; }

        public int? id_faculty { get; set; }

        public bool isActive { get; set; }
    }
}
