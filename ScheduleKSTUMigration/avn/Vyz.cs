namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vyz")]
    public partial class Vyz
    {
        [Key]
        public int IDVyz { get; set; }

        [StringLength(500)]
        public string NameVyz { get; set; }

        [StringLength(26)]
        public string IPVyz { get; set; }

        [StringLength(50)]
        public string AppVersion { get; set; }
    }
}
