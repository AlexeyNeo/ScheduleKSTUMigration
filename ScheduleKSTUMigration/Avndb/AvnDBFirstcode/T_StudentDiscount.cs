namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_StudentDiscount
    {
        [Key]
        public int id_StudentDiscount { get; set; }

        public int? id_group { get; set; }

        public int? id_rate { get; set; }

        public int id_student { get; set; }

        public int id_year { get; set; }

        public double sumDiscount { get; set; }
    }
}
