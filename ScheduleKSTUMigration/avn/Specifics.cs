namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Specifics
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Specifics()
        {
            Auditoriums = new HashSet<Auditoriums>();
        }

        [Key]
        public int id_specifics { get; set; }

        [Column("specifics")]
        [StringLength(50)]
        public string specifics1 { get; set; }

        [StringLength(10)]
        public string short_specifics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Auditoriums> Auditoriums { get; set; }
    }
}
