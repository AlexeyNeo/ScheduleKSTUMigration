namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class f_educ_vid
    {
        [Key]
        public int id_f_educ_vid { get; set; }

        [Column("f_educ_vid")]
        [StringLength(50)]
        public string f_educ_vid1 { get; set; }

        [StringLength(50)]
        public string sh_f_educ_vid { get; set; }
    }
}
