namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_SG_Citizenship_fakylty
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_s_g { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [Key]
        [Column("p23-2", Order = 2)]
        [StringLength(100)]
        public string p23_2 { get; set; }

        [StringLength(50)]
        public string stukture { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_speciality { get; set; }

        [StringLength(457)]
        public string spec { get; set; }

        public int? id_group { get; set; }

        [StringLength(50)]
        public string p20 { get; set; }

        public int? id_student { get; set; }

        [StringLength(70)]
        public string s_fio { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool Male { get; set; }

        public int? id_bk { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(15)]
        public string name { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_Citizenship { get; set; }

        [StringLength(25)]
        public string Citizenship { get; set; }

        public int? o_z { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_f_educ { get; set; }
    }
}
