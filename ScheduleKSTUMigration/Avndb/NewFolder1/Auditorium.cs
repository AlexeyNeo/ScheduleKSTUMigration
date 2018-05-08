namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Auditorium
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Auditorium()
        {
            SCHDayOffAuditories = new HashSet<SCHDayOffAuditory>();
        }

        [Key]
        public int id_auditorium { get; set; }

        public int? id_korpus { get; set; }

        [StringLength(20)]
        public string number { get; set; }

        public int contain { get; set; }

        public int? specific { get; set; }

        [StringLength(100)]
        public string note { get; set; }

        public double? square { get; set; }

        public int? id_faculty { get; set; }

        public int? id_otdel_1 { get; set; }

        public int? id_kafedra { get; set; }

        public int? body { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCHDayOffAuditory> SCHDayOffAuditories { get; set; }

        public virtual Specific Specific1 { get; set; }
    }
}
