namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("shet")]
    public partial class shet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public shet()
        {
            uslugis = new HashSet<uslugi>();
        }

        [Key]
        public int id_shet { get; set; }

        [Column("shet")]
        [Required]
        [StringLength(10)]
        public string shet1 { get; set; }

        [StringLength(50)]
        public string n_shet { get; set; }

        [StringLength(10)]
        public string shet2 { get; set; }

        [StringLength(50)]
        public string n_shet2 { get; set; }

        public int? id_kassa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<uslugi> uslugis { get; set; }
    }
}
