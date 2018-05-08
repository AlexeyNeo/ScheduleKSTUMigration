namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GAK_member_speciality
    {
        [Key]
        public int id_GAK_member_speciality { get; set; }

        [StringLength(200)]
        public string member_name { get; set; }

        public int? id_faculty { get; set; }

        public int? id_special { get; set; }

        public int? id_member_type { get; set; }

        [StringLength(100)]
        public string title { get; set; }
    }
}
