namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class uch_zvanie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public uch_zvanie()
        {
            teacher_info = new HashSet<teacher_info>();
        }

        [Key]
        public int id_uch_zvanie { get; set; }

        [StringLength(50)]
        public string k6 { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<teacher_info> teacher_info { get; set; }
    }
}
