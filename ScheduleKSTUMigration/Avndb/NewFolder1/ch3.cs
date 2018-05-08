namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ch3
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_student { get; set; }

        public int? nenujen { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string p1 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string p2 { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(25)]
        public string p3 { get; set; }

        public DateTime? BirthDate { get; set; }

        [StringLength(25)]
        public string nowReg { get; set; }

        [StringLength(25)]
        public string nowDist { get; set; }

        [StringLength(25)]
        public string homeReg { get; set; }

        [StringLength(25)]
        public string homeDist { get; set; }
    }
}
