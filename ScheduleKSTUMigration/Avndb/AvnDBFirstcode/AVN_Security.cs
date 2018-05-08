namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVN_Security
    {
        [Key]
        public int id_avn_security { get; set; }

        public int? id_avn_user { get; set; }

        public int? id_sql_user { get; set; }

        public virtual SQL_User SQL_User { get; set; }
    }
}
