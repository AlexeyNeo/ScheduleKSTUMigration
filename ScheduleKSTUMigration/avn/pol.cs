namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pol")]
    public partial class pol
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public pol()
        {
            teacher_info = new HashSet<teacher_info>();
        }

        [Key]
        public int id_pol { get; set; }

        public bool? mail { get; set; }

        [StringLength(50)]
        public string p17 { get; set; }

        [StringLength(5)]
        public string oper { get; set; }

        public DateTime? u_date { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<teacher_info> teacher_info { get; set; }
    }
}
