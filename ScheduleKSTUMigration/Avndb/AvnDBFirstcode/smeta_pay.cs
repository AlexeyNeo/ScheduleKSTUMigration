namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class smeta_pay
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        public int? id_a_year { get; set; }

        public int? id_rate { get; set; }

        public int? id_student { get; set; }

        public double? p102 { get; set; }

        public int? id_group { get; set; }
    }
}
