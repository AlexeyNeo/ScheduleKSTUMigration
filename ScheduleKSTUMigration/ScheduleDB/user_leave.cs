namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user_leave
    {
        [Key]
        public int id_user_leave { get; set; }

        public int? id_login { get; set; }

        public int? id_leave { get; set; }
    }
}
