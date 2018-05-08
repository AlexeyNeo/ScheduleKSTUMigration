namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Anketirovanie_Questions
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int QuestionnaireId { get; set; }

        [Key]
        [Column(Order = 2)]
        public string QuestionRu { get; set; }

        [Key]
        [Column(Order = 3)]
        public string QuestionKg { get; set; }

        [StringLength(50)]
        public string AnswerType { get; set; }
    }
}
