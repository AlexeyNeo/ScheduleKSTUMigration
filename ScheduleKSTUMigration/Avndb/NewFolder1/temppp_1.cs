namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temppp_1
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_payment { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int pe { get; set; }

        public int? id_student { get; set; }

        public int? id_teacher { get; set; }

        public int? id_abiturient { get; set; }

        [StringLength(100)]
        public string dopol { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_oplata { get; set; }

        [StringLength(200)]
        public string osnovanie { get; set; }

        [StringLength(200)]
        public string primech { get; set; }

        public int? id_speciality { get; set; }

        public int? id_rate { get; set; }

        public int? id_a_year { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_uslug { get; set; }

        [Key]
        [Column(Order = 5)]
        public double p102 { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime p103 { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int p104 { get; set; }

        [StringLength(100)]
        public string p104_1 { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_v_opl { get; set; }

        public DateTime? data_prikaz { get; set; }

        [StringLength(20)]
        public string dop_info { get; set; }

        [StringLength(10)]
        public string num_prikaz { get; set; }

        public DateTime? u_date { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kassa { get; set; }

        public int? new_speciality { get; set; }

        public int? old_rate { get; set; }

        public double? p102Next { get; set; }

        public int? id_a_yearNext { get; set; }

        public double? p102NewSpec { get; set; }

        public int? id_newSpecP102 { get; set; }

        public int? id_newYear { get; set; }

        public int? id_newRate { get; set; }

        public int? id_newGroup { get; set; }

        [StringLength(50)]
        public string tmp { get; set; }

        public int? id_slushatel { get; set; }

        public int? id_group_slushatel { get; set; }

        public double? temp_minus { get; set; }

        public int? mov_move { get; set; }

        [StringLength(100)]
        public string host { get; set; }

        [Key]
        [Column(Order = 10, TypeName = "numeric")]
        public decimal id_onlinePaymentStream { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool isOnlinePaymentStreamCanceled { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id_onlinePayment { get; set; }

        public int? Expr1 { get; set; }

        [StringLength(70)]
        public string s_fio { get; set; }
    }
}
