namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class w_s
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public w_s()
        {
            nedeli = new HashSet<nedeli>();
            semester = new HashSet<semester>();
        }

        [Key]
        public int id_w_s { get; set; }

        [Required]
        [StringLength(24)]
        public string p42 { get; set; }

        [StringLength(24)]
        public string p42_KG { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [StringLength(50)]
        public string p42_1 { get; set; }

        [StringLength(50)]
        public string p42_2 { get; set; }

        public short? ws_sort { get; set; }

        public int? opl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nedeli> nedeli { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<semester> semester { get; set; }
    }
}
