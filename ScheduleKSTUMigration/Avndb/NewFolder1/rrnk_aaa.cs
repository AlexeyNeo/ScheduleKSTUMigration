namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rrnk_aaa
    {
        public int? id_rrnk { get; set; }

        public int? id_teacher { get; set; }

        public int? id_group { get; set; }

        public int? id_type_chasov { get; set; }

        public double? plan_nagr { get; set; }

        public int? id_a_year { get; set; }

        public int? id_semester { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kafedra { get; set; }

        public int? id_discipline { get; set; }

        public int? id_examination { get; set; }

        [Key]
        [Column(Order = 1)]
        public double p51 { get; set; }

        [Key]
        [Column(Order = 2)]
        public double p52 { get; set; }

        [Key]
        [Column(Order = 3)]
        public double p53 { get; set; }

        public double? seminar { get; set; }
    }
}
