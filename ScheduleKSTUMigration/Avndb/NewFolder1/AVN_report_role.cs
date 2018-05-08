namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVN_report_role
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AVN_report_role()
        {
            AVN_rep_user = new HashSet<AVN_rep_user>();
        }

        [Key]
        public int id_AVN_report_role { get; set; }

        [StringLength(100)]
        public string report_role { get; set; }

        [StringLength(50)]
        public string reports { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AVN_rep_user> AVN_rep_user { get; set; }
    }
}
