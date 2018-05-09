namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVN_Test_vopros
    {
        [Key]
        public int id_test_vopros { get; set; }

        public string names { get; set; }

        public int? id_test_type { get; set; }

        public int? id_test_category { get; set; }
    }
}
