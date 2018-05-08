namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class komul_GPA
    {
        public int? id_a_year { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_w_s { get; set; }

        public int? id_semester { get; set; }

        public int? id_group { get; set; }

        public int? id_student { get; set; }

        public double? kb { get; set; }

        public int? Krdt1 { get; set; }

        public int? Krdt2 { get; set; }
    }
}
