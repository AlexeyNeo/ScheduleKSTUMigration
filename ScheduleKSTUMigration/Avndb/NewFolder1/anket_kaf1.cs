namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class anket_kaf1
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int YearId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_w_s { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kafedra { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TeacherId { get; set; }

        public double? ball1 { get; set; }

        public double? ball2 { get; set; }

        public double? ball3 { get; set; }

        public double? ball4 { get; set; }

        public double? ball5 { get; set; }

        public double? ball6 { get; set; }

        public double? ball7 { get; set; }

        public double? ball8 { get; set; }

        public double? ball9 { get; set; }

        public double? ball10 { get; set; }

        public double? ball11 { get; set; }

        public double? ball12 { get; set; }

        public double? ball13 { get; set; }
    }
}
