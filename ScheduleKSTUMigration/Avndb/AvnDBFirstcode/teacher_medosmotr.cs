namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class teacher_medosmotr
    {
        [Key]
        public int id_teacher_medosmotr { get; set; }

        public int? id_teacher { get; set; }

        [StringLength(250)]
        public string medosmotr { get; set; }

        public DateTime? medosmotr_date { get; set; }

        [StringLength(250)]
        public string Descpintion { get; set; }

        public DateTime? AVN_date { get; set; }
    }
}
