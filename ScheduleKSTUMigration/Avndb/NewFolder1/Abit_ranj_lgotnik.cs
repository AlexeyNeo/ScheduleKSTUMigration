namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Abit_ranj_lgotnik
    {
        public int? id_a_year { get; set; }

        public DateTime? DateRegistr { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_abit { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(152)]
        public string FIO { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte tour { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_bk { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(15)]
        public string bk_name { get; set; }

        public int? id_faculty { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string fakult { get; set; }

        public int? id_direction { get; set; }

        [StringLength(351)]
        public string direction { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_speciality { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool recom { get; set; }

        [StringLength(50)]
        public string Recom_protokol { get; set; }

        public DateTime? Recom_date { get; set; }

        [StringLength(25)]
        public string NumberSertRT { get; set; }

        public int? BallOnRepsTest { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int physics { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int math { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int bioligy { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int chemistry { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int history { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int english { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short IDPlase { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(25)]
        public string NamePlase { get; set; }

        public int? sum_dop { get; set; }

        public int? sum { get; set; }

        [Key]
        [Column(Order = 16)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ORT_butjet { get; set; }

        [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ORT_contrak { get; set; }

        [Key]
        [Column(Order = 18)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ORT_biology { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ORT_history { get; set; }

        [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ORT_chemistry { get; set; }

        [Key]
        [Column(Order = 21)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ORT_physics { get; set; }

        [Key]
        [Column(Order = 22)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ORT_english { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ORT_math { get; set; }

        [Key]
        [Column(Order = 24)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDStudent { get; set; }

        [Key]
        [Column(Order = 25)]
        public bool podtver { get; set; }

        public DateTime? date_podtver { get; set; }

        [Key]
        [Column(Order = 26)]
        public bool zachisl { get; set; }

        [StringLength(15)]
        public string number_zachisl { get; set; }

        public DateTime? date_zachisl { get; set; }

        public int? id_category { get; set; }

        [StringLength(50)]
        public string n_category { get; set; }

        [Key]
        [Column(Order = 27)]
        public bool Takebackdocs { get; set; }

        public bool? Orphan { get; set; }

        public bool? Invalid12Group { get; set; }
    }
}
