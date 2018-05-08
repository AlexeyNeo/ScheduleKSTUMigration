namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class f_educ
    {
        [Key]
        [Column(Order = 0)]
        public int id_f_educ { get; set; }

        [Required]
        [StringLength(10)]
        public string p108_1 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string p108 { get; set; }

        public int? o_z { get; set; }

        public int? max_rate_id { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public int? id_f_educ_vid { get; set; }

        [StringLength(75)]
        public string p108k { get; set; }

        public int? o_z_d { get; set; }

        public int? sort { get; set; }

        public int sort_schedule { get; set; }

        [StringLength(50)]
        public string z_o_d { get; set; }
    }
}
