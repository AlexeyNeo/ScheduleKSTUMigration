namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bk")]
    public partial class bk
    {
        [Key]
        public int id_bk { get; set; }

        [Required]
        [StringLength(15)]
        public string name { get; set; }

        [Required]
        [StringLength(1)]
        public string s_name { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }
    }
}
