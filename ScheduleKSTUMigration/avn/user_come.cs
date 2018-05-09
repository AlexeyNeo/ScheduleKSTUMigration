namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user_come
    {
        [Key]
        public int id_user_come { get; set; }

        public int? id_login { get; set; }

        public int? id_come { get; set; }
    }
}
