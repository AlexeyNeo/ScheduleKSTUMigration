namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CallEducationInst")]
    public partial class CallEducationInst
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CallEducationInst()
        {
            Ab_InfoOnEdIns = new HashSet<Ab_InfoOnEdIns>();
            InfoOnEdIns = new HashSet<InfoOnEdIns>();
        }

        [Key]
        public int IDCall { get; set; }

        public int TypeEdIns { get; set; }

        public int RegionEducat { get; set; }

        public int DistrictEducat { get; set; }

        public int? CityEducat { get; set; }

        public int? VillageEducat { get; set; }

        [Required]
        [StringLength(50)]
        public string CallEducat { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public int? RepublicEducat { get; set; }

        public bool? visible { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ab_InfoOnEdIns> Ab_InfoOnEdIns { get; set; }

        public virtual TypeScholl TypeScholl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoOnEdIns> InfoOnEdIns { get; set; }
    }
}
