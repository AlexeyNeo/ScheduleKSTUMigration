namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Abit_svod_kateg2
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_student { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool del { get; set; }

        public int? id_a_year { get; set; }

        public bool? SertRespTest { get; set; }

        [StringLength(25)]
        public string NumberSertRT { get; set; }

        public int? PlaseSertORT { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string NamePlase { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TourORT { get; set; }

        public int? BallOnRepsTest { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int biolog { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int history { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int chemistry { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int phisics { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int english { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int math { get; set; }

        public int? Speciality { get; set; }

        public int? Faculties { get; set; }

        [Key]
        [Column(Order = 10)]
        public byte tour { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool recom { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool podt { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool zachisl { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool zabral { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short id_bk { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(15)]
        public string name { get; set; }

        public int? id_category { get; set; }

        [StringLength(50)]
        public string n_category { get; set; }

        public bool? Orphan { get; set; }

        public bool? Invalid12Group { get; set; }
    }
}
