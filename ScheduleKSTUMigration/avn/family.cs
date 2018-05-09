namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("family")]
    public partial class family
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public family()
        {
            family_ = new HashSet<family_>();
        }

        [Key]
        public int id_family { get; set; }

        [StringLength(50)]
        public string p15 { get; set; }

        [StringLength(5)]
        public string oper { get; set; }

        public DateTime? u_date { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<family_> family_ { get; set; }
    }
}
