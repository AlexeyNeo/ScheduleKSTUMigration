namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_ebe_var
    {
        [Key]
        public int id_user_ebe_var { get; set; }

        public int? id_ebe_var { get; set; }

        public int? id_login { get; set; }
    }
}
