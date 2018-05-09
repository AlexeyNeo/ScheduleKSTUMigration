namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Mil_R_Voisk
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mil_R_Voisk()
        {
            mil_card_ = new HashSet<mil_card_>();
        }

        [Key]
        public int id_r_voisk { get; set; }

        [StringLength(20)]
        public string R_voisk { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<mil_card_> mil_card_ { get; set; }
    }
}
