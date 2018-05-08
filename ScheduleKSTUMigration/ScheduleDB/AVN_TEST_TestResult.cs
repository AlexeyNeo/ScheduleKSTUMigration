namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVN_TEST_TestResult
    {
        [Key]
        public int id_AVN_TEST_TestResult { get; set; }

        public int? id { get; set; }

        public int? id_test { get; set; }

        public int? id_student { get; set; }

        public int? id_fac { get; set; }

        public int? ig_group { get; set; }

        public int? id_semestr { get; set; }

        public int? id_disciplina { get; set; }

        public int? id_examination { get; set; }

        public int? id_regulation { get; set; }

        [StringLength(10)]
        public string VidTesta { get; set; }

        [Column(TypeName = "image")]
        public byte[] questions { get; set; }

        [Column(TypeName = "image")]
        public byte[] answers { get; set; }

        public int? attempt { get; set; }

        [StringLength(20)]
        public string zdal { get; set; }

        public int? pOtv { get; set; }

        public int? ball { get; set; }

        [Column(TypeName = "image")]
        public byte[] image { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public DateTime? GenerateDate { get; set; }

        [StringLength(50)]
        public string IpAddress { get; set; }

        [StringLength(50)]
        public string pole { get; set; }

        public int? id_pole { get; set; }

        public DateTime? AVNUPDATE { get; set; }

        public int? RightAnsvers { get; set; }

        public int? id_f_e { get; set; }

        public bool isHandled { get; set; }
    }
}
