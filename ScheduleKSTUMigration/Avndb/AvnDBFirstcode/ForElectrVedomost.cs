namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ForElectrVedomost")]
    public partial class ForElectrVedomost
    {
        public double? prov_reyt { get; set; }

        public int? id_teacher { get; set; }

        public int? id_a_year { get; set; }

        public int? id_group { get; set; }

        public int? id_semester { get; set; }

        public int? id_discipline { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(300)]
        public string p34 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string p43 { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string p32 { get; set; }

        public int? id_login { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_rate { get; set; }

        [StringLength(457)]
        public string spec { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_speciality { get; set; }

        public int? id_examination { get; set; }

        [StringLength(50)]
        public string p30 { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_f_educ { get; set; }

        public bool? isSelect { get; set; }
    }
}
