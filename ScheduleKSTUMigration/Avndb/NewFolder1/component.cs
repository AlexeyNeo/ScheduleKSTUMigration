namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("component")]
    public partial class component
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public component()
        {
            educ_sh = new HashSet<educ_sh>();
        }

        [Key]
        public int id_component { get; set; }

        [Column("component")]
        [StringLength(50)]
        public string component1 { get; set; }

        [StringLength(10)]
        public string s_component { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public int? kpv { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<educ_sh> educ_sh { get; set; }
    }
}