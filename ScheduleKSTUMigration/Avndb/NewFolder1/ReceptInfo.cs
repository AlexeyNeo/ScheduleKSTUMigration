namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReceptInfo")]
    public partial class ReceptInfo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDStudent { get; set; }

        public bool Recepted { get; set; }

        public bool? OrderRecept { get; set; }

        [StringLength(15)]
        public string NumberOrder { get; set; }

        public DateTime? DateOrder { get; set; }

        [StringLength(15)]
        public string NumberProtocol { get; set; }

        public DateTime? DateProtocol { get; set; }

        public int? Faculties { get; set; }

        public bool? not_came { get; set; }

        public int? Directions { get; set; }

        public int? temp_abit_spec { get; set; }

        public int? Speciality { get; set; }

        public bool? test_failed { get; set; }

        [StringLength(40)]
        public string RegNum { get; set; }

        public bool? DayForm { get; set; }

        public byte tour { get; set; }

        public bool Recom_for_reccept { get; set; }

        [Column("__Recom_num")]
        public byte? C__Recom_num { get; set; }

        public DateTime? Recom_date { get; set; }

        [StringLength(50)]
        public string Recom_protokol { get; set; }

        public DateTime? DateResept { get; set; }

        public DateTime? DateDeliveryDoc { get; set; }

        public bool confirm_date_for_reccept { get; set; }

        public bool? LanguageRus { get; set; }

        public short FormContract { get; set; }

        public int? Payment_fr_kass { get; set; }

        public DateTime? DatePayment_fr_kass { get; set; }

        public int? Payment { get; set; }

        public DateTime? DatePayment { get; set; }

        public int? id_category { get; set; }

        public DateTime? category_date { get; set; }

        public bool Takebackdocs { get; set; }

        public DateTime? Takebackdocsdate { get; set; }

        public DateTime? DateReg { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [StringLength(20)]
        public string AVN_User_Update { get; set; }

        public bool Pay { get; set; }

        public int ResultSobesedovania { get; set; }

        public bool ORT_AfterTehnicum { get; set; }

        public double? atestat { get; set; }

        public double? atestat_exzamen { get; set; }
    }
}
