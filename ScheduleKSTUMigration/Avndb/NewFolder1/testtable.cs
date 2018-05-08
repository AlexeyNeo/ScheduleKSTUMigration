namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("testtable")]
    public partial class testtable
    {
        public int id { get; set; }

        [StringLength(50)]
        public string value1 { get; set; }

        [StringLength(50)]
        public string value2 { get; set; }
    }
}
