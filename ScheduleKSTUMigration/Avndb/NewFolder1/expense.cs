namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("expense")]
    public partial class expense
    {
        [Key]
        public int id_expense { get; set; }

        public int pe { get; set; }

        public int? id_student { get; set; }

        public int? id_teacher { get; set; }

        public int? id_abiturient { get; set; }

        [StringLength(100)]
        public string dopol { get; set; }

        public int? id_faculty { get; set; }

        [StringLength(200)]
        public string osnovanie { get; set; }

        [StringLength(200)]
        public string primech { get; set; }

        public int? id_speciality { get; set; }

        public int? id_rate { get; set; }

        public int? id_group { get; set; }

        public int? id_a_year { get; set; }

        public int? id_uslug { get; set; }

        public int? id_payment { get; set; }

        public double p102 { get; set; }

        public DateTime p103 { get; set; }

        public int p104 { get; set; }

        [StringLength(20)]
        public string p104_1 { get; set; }

        public int id_v_opl { get; set; }

        public DateTime? data_prikaz { get; set; }

        [StringLength(20)]
        public string dop_info { get; set; }

        [StringLength(10)]
        public string num_prikaz { get; set; }

        public bool? Onul { get; set; }

        [StringLength(20)]
        public string oper { get; set; }

        public DateTime? u_date { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public int id_kassa { get; set; }

        public int? id_slushatel { get; set; }

        public int? id_group_slushatel { get; set; }
    }
}
