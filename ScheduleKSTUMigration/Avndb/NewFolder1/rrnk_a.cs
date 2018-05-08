namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rrnk_a
    {
        public int? id_rrnk { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kafedra { get; set; }

        public int? id_a_year { get; set; }

        public int? id_teacher { get; set; }

        public int? id_semester { get; set; }

        public int? id_discipline { get; set; }

        public int? id_examination { get; set; }

        public int? id_group { get; set; }

        public int? id_type_chasov { get; set; }

        public double? plan_nagr { get; set; }

        public int? o_z { get; set; }

        [Key]
        [Column(Order = 1)]
        public double up_lk { get; set; }

        [Key]
        [Column(Order = 2)]
        public double up_lb { get; set; }

        [Key]
        [Column(Order = 3)]
        public double up_pr { get; set; }

        public double? up_seminar { get; set; }
    }
}
