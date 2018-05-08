namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Z_LMS_SMS_KR
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_a_year { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string p32 { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [Key]
        [Column("p23-2", Order = 3)]
        [StringLength(100)]
        public string p23_2 { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_rate { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string p22 { get; set; }

        [StringLength(454)]
        public string p25_2 { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        public int? osen_id_student { get; set; }

        public int? kol_S_SMS_OSEN_KT { get; set; }

        public int? kol_T_SMS_OSEN_KT { get; set; }

        public int? kol_KR_S_OSEN_KT { get; set; }

        public int? kol_RES_T_OSEN_KT { get; set; }

        public int? kol_S_SMS_OSEN_RK { get; set; }

        public int? kol_T_SMS_OSEN_RK { get; set; }

        public int? kol_KR_S_OSEN_RK { get; set; }

        public int? kol_RES_T_OSEN_RK { get; set; }

        public int? vesen_id_student { get; set; }

        public int? kol_S_SMS_VESEN_KT { get; set; }

        public int? kol_T_SMS_VESEN_KT { get; set; }

        public int? kol_KR_S_VESEN_KT { get; set; }

        public int? kol_RES_T_VESEN_KT { get; set; }
    }
}
