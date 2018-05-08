namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temp_Ainura
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
        [Column("p23-1", Order = 3)]
        [StringLength(50)]
        public string p23_1 { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_group { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_rate { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string p22 { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_student { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(25)]
        public string S_f { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(25)]
        public string S_n { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(25)]
        public string S_o { get; set; }

        [StringLength(50)]
        public string S_login { get; set; }

        [StringLength(32)]
        public string S_password { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(24)]
        public string p42 { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_discipline { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(300)]
        public string p34 { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kafedra { get; set; }

        [StringLength(300)]
        public string kafedra { get; set; }

        [StringLength(457)]
        public string spec { get; set; }

        public int? id_teacher { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(50)]
        public string p26 { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(50)]
        public string p27 { get; set; }

        [StringLength(50)]
        public string p28 { get; set; }
    }
}
