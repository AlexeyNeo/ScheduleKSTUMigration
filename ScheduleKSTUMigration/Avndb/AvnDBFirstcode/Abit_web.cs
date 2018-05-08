namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Abit_web
    {
        public int? id_a_year { get; set; }

        public DateTime? DateRegistr { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_abit { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string p1 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string p2 { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string p3 { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_bk { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(15)]
        public string bk_name { get; set; }

        public int? id_direction { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_speciality { get; set; }

        [StringLength(351)]
        public string direction { get; set; }

        [StringLength(25)]
        public string NumberSertRT { get; set; }

        public int? BallOnRepsTest { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int physics { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int math { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int bioligy { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int chemistry { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int history { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int english { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short IDPlase { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(25)]
        public string NamePlase { get; set; }

        public int? id_category { get; set; }
    }
}
