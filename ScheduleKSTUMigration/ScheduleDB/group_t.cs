namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class group_t
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public group_t()
        {
            movement_t = new HashSet<movement_t>();
            mov_ved_giv = new HashSet<mov_ved_giv>();
        }

        [Key]
        public int id_group { get; set; }

        public int id_com_gspe { get; set; }

        public int id_group_y { get; set; }

        [StringLength(20)]
        public string dop { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public bool? ind_name_gr { get; set; }

        [StringLength(6)]
        public string id_ua_GRP { get; set; }

        public virtual com_gspe com_gspe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<movement_t> movement_t { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mov_ved_giv> mov_ved_giv { get; set; }
    }
}
