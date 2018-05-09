namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SCHSubjectShortName")]
    public partial class SCHSubjectShortName
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_discipline { get; set; }

        [Required]
        [StringLength(100)]
        public string SubjectShortName { get; set; }
    }
}
