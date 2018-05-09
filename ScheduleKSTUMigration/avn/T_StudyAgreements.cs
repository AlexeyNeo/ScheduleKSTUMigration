namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_StudyAgreements
    {
        [Key]
        public int id_studyAgreement { get; set; }

        public int id_university { get; set; }

        public int id_user { get; set; }

        public int id_country { get; set; }

        public int id_institution { get; set; }

        [Column(TypeName = "date")]
        public DateTime signingDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime validity { get; set; }

        [Required]
        [StringLength(1000)]
        public string collaborationArea { get; set; }

        [Required]
        [StringLength(2000)]
        public string note { get; set; }

        [Required]
        [StringLength(1000)]
        public string acceptedFiles { get; set; }

        [Required]
        [StringLength(1000)]
        public string filesForPdf { get; set; }

        public bool isDeleted { get; set; }
    }
}
