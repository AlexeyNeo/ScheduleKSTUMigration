namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Zoomo_VIEW
    {
        [StringLength(25)]
        public string NumberSertRT { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(152)]
        public string FIO_abit { get; set; }

        [Column("p24-2")]
        [StringLength(300)]
        public string p24_2 { get; set; }

        public int? BallOnRepsTest { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int matem { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int phisic { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int biolog { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int chem { get; set; }

        [Key]
        [Column(Order = 5)]
        public bool Recom_for_reccept { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool confirm_date_for_reccept { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool Recepted { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short id_bk { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(15)]
        public string name { get; set; }

        public int? Faculties { get; set; }
    }
}
