namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_SmsTempActions
    {
        [Key]
        public long id_smsTempActions { get; set; }

        public int id_smsAction { get; set; }

        public int id_user { get; set; }

        public int id_userType { get; set; }

        public int id_group { get; set; }

        [Column(TypeName = "date")]
        public DateTime onDate { get; set; }

        public bool isDeleted { get; set; }

        public bool unknown { get; set; }
    }
}
