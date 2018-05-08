namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estimation")]
    public partial class estimation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public estimation()
        {
            ees = new HashSet<ee>();
            kv_job = new HashSet<kv_job>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_estimation { get; set; }

        [StringLength(50)]
        public string p31 { get; set; }

        [Column("p31-2")]
        [StringLength(5)]
        public string p31_2 { get; set; }

        [StringLength(5)]
        public string diplom { get; set; }

        [StringLength(10)]
        public string ved1 { get; set; }

        [StringLength(10)]
        public string ved2 { get; set; }

        [StringLength(10)]
        public string ved3 { get; set; }

        [StringLength(20)]
        public string p31_1 { get; set; }

        [StringLength(30)]
        public string p31k { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ee> ees { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kv_job> kv_job { get; set; }
    }
}
