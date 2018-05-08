namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("leave")]
    public partial class leave
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public leave()
        {
            movement_t = new HashSet<movement_t>();
        }

        [Key]
        public int id_leave { get; set; }

        [Column("leave")]
        [Required]
        [StringLength(40)]
        public string leave1 { get; set; }

        public int? id_come { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public int vnutr_perevod { get; set; }

        [StringLength(50)]
        public string akadem { get; set; }

        [StringLength(50)]
        public string akadem_kg { get; set; }

        [StringLength(50)]
        public string leave_kg { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<movement_t> movement_t { get; set; }
    }
}
