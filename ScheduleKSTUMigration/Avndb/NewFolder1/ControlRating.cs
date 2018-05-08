namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ControlRating")]
    public partial class ControlRating
    {
        [Key]
        public int id_control_rating { get; set; }

        public int? id_group { get; set; }

        public int? id_semester { get; set; }

        public int? id_a_year { get; set; }

        public int? id_faculty { get; set; }

        public int? id_discipline { get; set; }

        public DateTime? Date_1 { get; set; }

        [StringLength(10)]
        public string Time_1 { get; set; }

        [StringLength(10)]
        public string Audience_1 { get; set; }

        public int? id_typeControl_1 { get; set; }
    }
}
