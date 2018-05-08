namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temp_for_rasp
    {
        public int? id_a_year { get; set; }

        public int? id_semester { get; set; }

        public int? id_discipline { get; set; }

        public int? id_group { get; set; }

        public int? id_teacher { get; set; }

        public int? potok { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Kod_rab { get; set; }

        [Key]
        [Column(Order = 1)]
        public double LK { get; set; }

        [Key]
        [Column(Order = 2)]
        public double LB { get; set; }

        [Key]
        [Column(Order = 3)]
        public double PR { get; set; }

        public double? SEM { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kafedra { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int aud_specific { get; set; }
    }
}
