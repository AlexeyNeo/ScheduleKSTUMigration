namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Licence")]
    public partial class Licence
    {
        [Key]
        public int IDLicence { get; set; }

        [Required]
        [StringLength(150)]
        public string Resolution { get; set; }

        [Required]
        [StringLength(10)]
        public string ResolutionBeg { get; set; }

        [Required]
        [StringLength(10)]
        public string ResolutionEnd { get; set; }

        [Required]
        [StringLength(150)]
        public string Supplement { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }
    }
}
