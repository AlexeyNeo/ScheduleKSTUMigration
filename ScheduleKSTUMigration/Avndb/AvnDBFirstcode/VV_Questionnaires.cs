namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VV_Questionnaires
    {
        [Key]
        [Column(Order = 0)]
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
        [StringLength(50)]
        public string Status { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime StartDate { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime EndDate { get; set; }

        public byte? id_type_Questionnaires { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(100)]
        public string QuestionnaireType { get; set; }
    }
}
