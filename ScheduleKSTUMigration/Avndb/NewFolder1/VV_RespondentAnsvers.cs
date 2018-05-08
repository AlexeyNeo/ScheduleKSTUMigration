namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VV_RespondentAnsvers
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int YearId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SemesterId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_Questionnaires { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(500)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime StartDate { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime EndDate { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_Questions { get; set; }

        [Key]
        [Column(Order = 7)]
        public string QuestionRu { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_Ansvers { get; set; }

        [Key]
        [Column(Order = 9)]
        public string AnswerRu { get; set; }

        public int? kol { get; set; }

        [StringLength(50)]
        public string AnswerType { get; set; }
    }
}
