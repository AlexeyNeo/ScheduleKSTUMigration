namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobileProblem")]
    public partial class MobileProblem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MobileProblem()
        {
            MobileContactBacks = new HashSet<MobileContactBack>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        public int CreateUserID { get; set; }

        public DateTime RecordTimeStamp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MobileContactBack> MobileContactBacks { get; set; }
    }
}
