namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InfoOnTesting")]
    public partial class InfoOnTesting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDStudent { get; set; }

        public int? Building { get; set; }

        public int? Audience { get; set; }

        public int? NumberPlace { get; set; }

        public int? AmountPlace { get; set; }

        public DateTime? DateExam { get; set; }

        public short? Mathematics { get; set; }

        public short? Physics { get; set; }

        public short? Chemistry { get; set; }

        public short? History { get; set; }

        public short? Geography { get; set; }

        public short? Literature { get; set; }

        public short? Economice { get; set; }

        public short? Informatics { get; set; }

        public short? Biologies { get; set; }

        public short? Language { get; set; }

        public short? RusLanguage { get; set; }

        public short? KyrLanguage { get; set; }

        public short? EngLanguage { get; set; }

        public short? DocLanguage { get; set; }

        public short? FrnLanguage { get; set; }

        public int? Total { get; set; }

        public int? MinEstimation { get; set; }

        public bool? OutsideОfСomp { get; set; }

        public bool? OneExamin { get; set; }

        public bool SuccessTest { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [StringLength(20)]
        public string AVN_User_Update { get; set; }

        [Column(TypeName = "ntext")]
        public string sobesed { get; set; }

        [Column(TypeName = "ntext")]
        public string vnekonkurs { get; set; }
    }
}
