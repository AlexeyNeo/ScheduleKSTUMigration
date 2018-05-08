namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tempttt")]
    public partial class tempttt
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_Questionnaires { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(500)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string QuestionnaireType { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_Questions { get; set; }

        [Key]
        [Column(Order = 4)]
        public string QuestionRu { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_Ansvers { get; set; }

        [Key]
        [Column(Order = 6)]
        public string AnswerRu { get; set; }

        public int? YearId { get; set; }

        public int? id_w_s { get; set; }

        public int? id_faculty { get; set; }

        public int? kol { get; set; }

        public int? kol_vop { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? proz { get; set; }
    }
}
