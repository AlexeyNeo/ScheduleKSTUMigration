namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVN_Test_samoozenka
    {
        [Key]
        public int id_test_samoozenka { get; set; }

        public int? id_student { get; set; }

        public int? id_test_vopros { get; set; }
    }
}
