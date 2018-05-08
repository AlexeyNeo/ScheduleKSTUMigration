namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("___Directions")]
    public partial class C___Directions
    {
        [Key]
        public int IDRecord { get; set; }

        public short IDFaculties { get; set; }

        [Required]
        [StringLength(25)]
        public string IDDirections { get; set; }

        [Required]
        [StringLength(255)]
        public string NameDirections { get; set; }

        [Required]
        [StringLength(25)]
        public string SmallNameDirect { get; set; }

        public short FormSt { get; set; }

        [Required]
        [StringLength(25)]
        public string Apprenticeship { get; set; }

        public int LicenceNum { get; set; }

        public short QualificationName { get; set; }

        public short StandardOfEducation { get; set; }

        public int CountStudens { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }
    }
}
