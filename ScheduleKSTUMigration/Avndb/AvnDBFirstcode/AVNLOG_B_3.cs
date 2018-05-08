namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVNLOG_B_3
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_user { get; set; }

        [StringLength(50)]
        public string detal { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string oldValue { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string newValue { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_semester { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime updated { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(100)]
        public string userComp { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id_logUpdated { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(77)]
        public string s_fio { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(300)]
        public string p34 { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_group { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_student { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_discipline { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(50)]
        public string surname { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(50)]
        public string name { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(50)]
        public string patronymic { get; set; }

        [StringLength(50)]
        public string p31 { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_estimation { get; set; }
    }
}
