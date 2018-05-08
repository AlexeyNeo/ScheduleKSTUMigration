namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Anket_Questions
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(500)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(500)]
        public string DescriptionKg { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Questions { get; set; }

        [Key]
        [Column(Order = 4)]
        public string QuestionRu { get; set; }

        [Key]
        [Column(Order = 5)]
        public string QuestionKg { get; set; }

        [StringLength(50)]
        public string AnswerType { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_Ansvers { get; set; }

        [Key]
        [Column(Order = 7)]
        public string AnswerRu { get; set; }

        [Key]
        [Column(Order = 8)]
        public string AnsverKg { get; set; }
    }
}
