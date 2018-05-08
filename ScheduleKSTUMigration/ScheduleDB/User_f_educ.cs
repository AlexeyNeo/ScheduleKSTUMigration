namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_f_educ
    {
        [Key]
        public int id_user_f_educ { get; set; }

        public int? id_f_educ { get; set; }

        public int? id_login { get; set; }
    }
}
