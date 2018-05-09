namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("oplata")]
    public partial class oplata
    {
        [Key]
        public int id_oplata { get; set; }

        [Column("oplata")]
        [Required]
        [StringLength(38)]
        public string oplata1 { get; set; }

        [StringLength(15)]
        public string s_opl { get; set; }

        [StringLength(5)]
        public string oper { get; set; }

        public DateTime? u_date { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }
    }
}
