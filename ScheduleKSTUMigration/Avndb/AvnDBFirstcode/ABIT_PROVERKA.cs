namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ABIT_PROVERKA
    {
        [Key]
        [Column(Order = 0)]
        public bool del { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        [StringLength(25)]
        public string NUMBER { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string fakult { get; set; }

        [StringLength(351)]
        public string direction { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string NamePlase { get; set; }

        public int? BallOnRepsTest { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int physics { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int math { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int bioligy { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int chemistry { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int history { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int english { get; set; }

        public DateTime? DateRegistr { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_abit { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(152)]
        public string FIO { get; set; }

        [Key]
        [Column(Order = 11)]
        public byte tour { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_bk { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(15)]
        public string bk_name { get; set; }

        public int? id_faculty { get; set; }

        public int? id_direction { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_speciality { get; set; }

        [Key]
        [Column(Order = 15)]
        public bool recom { get; set; }

        [StringLength(50)]
        public string Recom_protokol { get; set; }

        public DateTime? Recom_date { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short IDPlase { get; set; }

        public int? sum_dop { get; set; }

        public int? sum { get; set; }

        public int? ORT_butjet { get; set; }

        public int? ORT_contrak { get; set; }

        public int? ORT_biology { get; set; }

        public int? ORT_history { get; set; }

        public int? ORT_chemistry { get; set; }

        public int? ORT_physics { get; set; }

        public int? ORT_english { get; set; }

        public int? ORT_math { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDStudent { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool podtver { get; set; }

        public DateTime? date_podtver { get; set; }

        [Key]
        [Column(Order = 19)]
        public bool zachisl { get; set; }

        [StringLength(15)]
        public string number_zachisl { get; set; }

        public DateTime? date_zachisl { get; set; }

        public int? id_category { get; set; }

        [StringLength(50)]
        public string n_category { get; set; }

        [Key]
        [Column(Order = 20)]
        public bool Takebackdocs { get; set; }

        public DateTime? AVN_update { get; set; }
    }
}
