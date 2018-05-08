namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ControlRating_disc
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(300)]
        public string p34 { get; set; }

        public int? id_a_year { get; set; }

        public DateTime? Date_1 { get; set; }

        [StringLength(10)]
        public string Time_1 { get; set; }

        [StringLength(10)]
        public string Audience_1 { get; set; }

        public int? id_typeControl_1 { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_w_s { get; set; }
    }
}
