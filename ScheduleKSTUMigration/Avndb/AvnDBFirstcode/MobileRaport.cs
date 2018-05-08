namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobileRaport")]
    public partial class MobileRaport
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MobileRaport()
        {
            MobileRaportDetails = new HashSet<MobileRaportDetail>();
        }

        [Key]
        public int MobileAnnounceID { get; set; }

        public int FacultyID { get; set; }

        public int GroupID { get; set; }

        public string AddInfo { get; set; }

        public int CreateUserID { get; set; }

        public DateTime RecordTimeStamp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MobileRaportDetail> MobileRaportDetails { get; set; }
    }
}
