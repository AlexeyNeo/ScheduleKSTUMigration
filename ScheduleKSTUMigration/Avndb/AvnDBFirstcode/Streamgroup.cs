namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Streamgroup")]
    public partial class Streamgroup
    {
        public int? id_streamGroup { get; set; }

        public int? id_a_year { get; set; }

        public int? id_semester { get; set; }

        public int? id_discipline { get; set; }

        public int? id_group { get; set; }

        public int? id_teacher { get; set; }

        public int? groupstreamNum { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_streamType { get; set; }

        public int? o_z { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kafedra { get; set; }

        [Key]
        [Column(Order = 2)]
        public double up_lk { get; set; }

        [Key]
        [Column(Order = 3)]
        public double up_lb { get; set; }

        [Key]
        [Column(Order = 4)]
        public double up_pr { get; set; }

        public double? up_seminar { get; set; }
    }
}
