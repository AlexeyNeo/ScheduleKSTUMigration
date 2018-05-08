namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class name_and_surname_of_students
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string p1 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string p2 { get; set; }
    }
}
