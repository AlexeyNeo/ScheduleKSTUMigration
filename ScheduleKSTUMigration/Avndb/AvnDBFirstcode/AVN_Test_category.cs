namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVN_Test_category
    {
        [Key]
        public int id_test_category { get; set; }

        [StringLength(2)]
        public string Names { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}
