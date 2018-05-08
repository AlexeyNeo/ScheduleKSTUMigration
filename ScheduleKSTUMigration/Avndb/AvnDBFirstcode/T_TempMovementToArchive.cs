namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_TempMovementToArchive
    {
        public long id { get; set; }

        public int id_student { get; set; }

        public int id_group { get; set; }
    }
}
