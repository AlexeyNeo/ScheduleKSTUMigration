namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class abit_7
    {
        public int? Faculties { get; set; }

        public int? dz { get; set; }

        [Key]
        [Column(Order = 0)]
        public bool del { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Recepted { get; set; }
    }
}
