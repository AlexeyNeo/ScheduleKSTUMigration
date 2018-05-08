namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("user")]
    public partial class user
    {
        [Key]
        public int id_user { get; set; }

        [Column("user")]
        [Required]
        [StringLength(10)]
        public string user1 { get; set; }

        [StringLength(10)]
        public string parol { get; set; }
    }
}
