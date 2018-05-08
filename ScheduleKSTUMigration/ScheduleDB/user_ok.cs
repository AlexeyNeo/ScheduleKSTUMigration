namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user_ok
    {
        [Key]
        public int id_user_ok { get; set; }

        [Required]
        [StringLength(50)]
        public string user { get; set; }

        [Required]
        [StringLength(20)]
        public string user_name { get; set; }

        public int strukture { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public virtual structure structure { get; set; }
    }
}
