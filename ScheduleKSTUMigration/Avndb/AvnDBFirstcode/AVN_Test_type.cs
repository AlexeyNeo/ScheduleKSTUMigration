namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVN_Test_type
    {
        [Key]
        public int id_test_type { get; set; }

        [StringLength(250)]
        public string test_type { get; set; }

        [StringLength(250)]
        public string Description { get; set; }
    }
}
