namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("examination")]
    public partial class examination
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public examination()
        {
            educ_sh = new HashSet<educ_sh>();
            ee = new HashSet<ee>();
            mov_ved_giv = new HashSet<mov_ved_giv>();
        }

        [Key]
        public int id_examination { get; set; }

        [StringLength(50)]
        public string p30 { get; set; }

        [StringLength(5)]
        public string p30_1 { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public int? n_sh_uu { get; set; }

        public bool? For_rasp { get; set; }

        public byte? typeExamZach { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<educ_sh> educ_sh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ee> ee { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mov_ved_giv> mov_ved_giv { get; set; }
    }
}
