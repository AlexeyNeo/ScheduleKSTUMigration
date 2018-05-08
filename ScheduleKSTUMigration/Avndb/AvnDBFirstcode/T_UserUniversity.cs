namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_UserUniversity
    {
        [Key]
        public long id_userUniversity { get; set; }

        public int id_university { get; set; }

        public int id_user { get; set; }
    }
}
