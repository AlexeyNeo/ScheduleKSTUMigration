namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class plus_exp
    {
        public int? id_a_year { get; set; }

        public int? id_student { get; set; }

        public double? p102 { get; set; }

        public int? id_speciality { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_uslug { get; set; }

        public int? id_rate { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime p103 { get; set; }

        public int? id_group { get; set; }
    }
}
