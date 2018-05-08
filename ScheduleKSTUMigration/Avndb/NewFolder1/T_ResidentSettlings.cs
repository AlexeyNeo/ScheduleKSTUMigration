namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_ResidentSettlings
    {
        [Key]
        public int id_ResidentSettling { get; set; }

        public int id_student { get; set; }

        public DateTime dateEntered { get; set; }

        public DateTime dateOut { get; set; }

        public DateTime? AVN_Data { get; set; }

        [StringLength(250)]
        public string AVN_user { get; set; }
    }
}
