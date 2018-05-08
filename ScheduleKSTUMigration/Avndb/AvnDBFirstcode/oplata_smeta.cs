namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class oplata_smeta
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_payment { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pe { get; set; }

        public int? id_a_year { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        public int? id_speciality { get; set; }

        public int? id_rate { get; set; }

        public int? id_group { get; set; }

        public int? id_student { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_uslug { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(80)]
        public string uslugi { get; set; }

        [Key]
        [Column(Order = 5)]
        public double oplata { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int order { get; set; }

        [StringLength(100)]
        public string p104_1 { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_v_opl { get; set; }

        [StringLength(40)]
        public string p105 { get; set; }

        [Key]
        [Column(Order = 8)]
        public double smeta { get; set; }

        [Key]
        [Column("p14-7", Order = 9)]
        [StringLength(100)]
        public string p14_7 { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime data { get; set; }

        public int? priv_var { get; set; }
    }
}
