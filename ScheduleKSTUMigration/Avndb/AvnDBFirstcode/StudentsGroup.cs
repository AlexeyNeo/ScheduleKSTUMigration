namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StudentsGroup")]
    public partial class StudentsGroup
    {
        [StringLength(10)]
        public string idid { get; set; }

        public int? id_a_year { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_speciality { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_student { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDLanguage { get; set; }

        [Key]
        [Column("p23-2", Order = 4)]
        [StringLength(100)]
        public string p23_2 { get; set; }

        [StringLength(454)]
        public string p25_2 { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(152)]
        public string ab_fio { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(25)]
        public string NameLanguage { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(70)]
        public string v2 { get; set; }
    }
}
