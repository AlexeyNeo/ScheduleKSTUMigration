namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kass_1
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kassa { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime p103 { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int p104 { get; set; }

        [StringLength(100)]
        public string p104_1 { get; set; }

        [StringLength(50)]
        public string name_shet { get; set; }

        public double? p_p102 { get; set; }

        [StringLength(10)]
        public string shet { get; set; }

        public int? id_student { get; set; }

        public int? id_abiturient { get; set; }

        public int? id_teacher { get; set; }

        [StringLength(100)]
        public string dopol { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        public int? id_slushatel { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_v_opl { get; set; }

        public int? id_a_year { get; set; }

        public int? id_rate { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_uslug { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool isOnlinePaymentStreamCanceled { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(80)]
        public string uslugi { get; set; }
    }
}
