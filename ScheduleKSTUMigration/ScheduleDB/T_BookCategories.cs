namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_BookCategories
    {
        [Key]
        public int id_bookCategory { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        public int id_baseBookCategory { get; set; }
    }
}
