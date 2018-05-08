namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("specialityRR")]
    public partial class specialityRR
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_speciality { get; set; }

        [Column("p25-1")]
        [StringLength(50)]
        public string p25_1 { get; set; }

        [StringLength(454)]
        public string p25_2 { get; set; }

        public int? id_direction { get; set; }

        public int? id_opl { get; set; }

        [Key]
        [Column("p23-1", Order = 1)]
        [StringLength(50)]
        public string p23_1 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string p108 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_f_educ { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [Column("p25-2")]
        [StringLength(300)]
        public string p25_21 { get; set; }

        public int? id_a_year { get; set; }

        public int? kol_k { get; set; }

        public int? kol_b { get; set; }

        public bool? visible { get; set; }

        public int? max_rate_id { get; set; }
    }
}
