namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bf_0
    {
        public int? id_student { get; set; }

        public double? P102 { get; set; }

        public int? id_rate { get; set; }

        public int? id_group { get; set; }

        public int? id_a_year { get; set; }

        [Key]
        [Column(Order = 0)]
        public DateTime p103 { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int p104 { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime dateopl { get; set; }
    }
}
