namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ParentsInfo")]
    public partial class ParentsInfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_parentsInfo { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDStudent { get; set; }

        [StringLength(25)]
        public string SurnameFather { get; set; }

        [StringLength(25)]
        public string NameFather { get; set; }

        [StringLength(25)]
        public string PatronymicFather { get; set; }

        [StringLength(25)]
        public string PlaceJobFather { get; set; }

        [StringLength(25)]
        public string PostFather { get; set; }

        [StringLength(25)]
        public string SurnameMother { get; set; }

        [StringLength(25)]
        public string NameMother { get; set; }

        [StringLength(25)]
        public string PatronymicMother { get; set; }

        [StringLength(25)]
        public string PlaceJobMother { get; set; }

        [StringLength(25)]
        public string PostMother { get; set; }

        public int? id_reoublicParents { get; set; }

        public int? RegionHomeAddress { get; set; }

        public int? DistrictHomeAddress { get; set; }

        public int? CityHomeAddress { get; set; }

        public int? VillageHomeAddress { get; set; }

        [StringLength(255)]
        public string StreetHomeAddress { get; set; }

        [StringLength(16)]
        public string TelephoneHomeAddress { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [StringLength(20)]
        public string E_MailFather { get; set; }

        [StringLength(20)]
        public string TelephoneFather { get; set; }

        [StringLength(20)]
        public string E_MailMother { get; set; }

        [StringLength(20)]
        public string TelephoneMother { get; set; }

        public virtual Student Student { get; set; }
    }
}
