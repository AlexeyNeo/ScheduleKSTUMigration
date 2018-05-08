namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User_Kafedra
    {
        [Key]
        public int id_user_kafedra { get; set; }

        public int? id_kafedra { get; set; }

        public int? id_login { get; set; }
    }
}
