namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("semester")]
    public partial class semester
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public semester()
        {
            educ_sh = new HashSet<educ_sh>();
            mov_ved_giv = new HashSet<mov_ved_giv>();
            movement_t = new HashSet<movement_t>();
        }

        [Key]
        public int id_semester { get; set; }

        [Required]
        [StringLength(30)]
        public string p43 { get; set; }

        public int id_rate { get; set; }

        public int id_w_s { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<educ_sh> educ_sh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mov_ved_giv> mov_ved_giv { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<movement_t> movement_t { get; set; }

        public virtual rate rate { get; set; }

        public virtual w_s w_s { get; set; }
    }
}
