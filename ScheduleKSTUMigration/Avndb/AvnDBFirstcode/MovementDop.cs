namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MovementDop")]
    public partial class MovementDop
    {
        [Key]
        public int id_movementDop { get; set; }

        public int? id_student { get; set; }

        [StringLength(20)]
        public string prikaz { get; set; }

        public DateTime? data { get; set; }

        [StringLength(100)]
        public string primech { get; set; }
    }
}
