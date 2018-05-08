namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_Login
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_humanType { get; set; }

        [StringLength(200)]
        public string login { get; set; }

        [StringLength(32)]
        public string password { get; set; }

        public int? id_human { get; set; }

        public int? id_group { get; set; }

        public int? id_login { get; set; }

        [StringLength(152)]
        public string snp { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_human_typeFrom { get; set; }

        public int? id_speciality { get; set; }

        [StringLength(50)]
        public string p20 { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_f_educ { get; set; }

        public int? o_z { get; set; }

        public bool? canUploadUmk { get; set; }

        [StringLength(50)]
        public string e_mail { get; set; }
    }
}
