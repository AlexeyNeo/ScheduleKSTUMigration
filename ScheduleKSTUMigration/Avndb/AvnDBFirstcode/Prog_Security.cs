namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Prog_Security
    {
        [Key]
        public int id_prog_security { get; set; }

        public int? id_prog_list { get; set; }

        public int? id_sql_user { get; set; }
    }
}
