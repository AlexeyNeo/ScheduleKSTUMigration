namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ControlRating_gr_f
    {
        [StringLength(107)]
        public string gr_f { get; set; }

        public int? id_a_year { get; set; }

        public DateTime? Date_1 { get; set; }

        [StringLength(10)]
        public string Time_1 { get; set; }

        [StringLength(10)]
        public string Audience_1 { get; set; }

        public int? id_typeControl_1 { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_w_s { get; set; }
    }
}
