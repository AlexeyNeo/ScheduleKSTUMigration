namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("University")]
    public partial class University
    {
        [Key]
        public int IDUniversity { get; set; }

        [StringLength(200)]
        public string NameUniversity { get; set; }

        public short? RegionUniversity { get; set; }

        public short? DistrictUniversity { get; set; }

        public int? CityUniversity { get; set; }

        public int? VillageUniversity { get; set; }

        [StringLength(255)]
        public string StreetUniversity { get; set; }

        [StringLength(16)]
        public string TelephoneUniversity { get; set; }

        [StringLength(25)]
        public string FaxUniversity { get; set; }

        [StringLength(50)]
        public string RectorSurname { get; set; }

        [StringLength(50)]
        public string RectorName { get; set; }

        [StringLength(50)]
        public string RectorPatronymic { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }
    }
}
