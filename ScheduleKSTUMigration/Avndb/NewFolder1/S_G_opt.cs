namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_G_opt
    {
        [Key]
        public int id_S_G_opt { get; set; }

        public int? id_group { get; set; }

        public int? id_student { get; set; }

        public int? min_sem { get; set; }

        public int? max_sem { get; set; }

        public int? max_leave_sem { get; set; }
    }
}
