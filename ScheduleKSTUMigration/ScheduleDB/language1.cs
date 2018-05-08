namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("languages")]
    public partial class language1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public language1()
        {
            Language_options = new HashSet<Language_options>();
        }

        [Key]
        public int id_lang { get; set; }

        [Required]
        [StringLength(20)]
        public string lang { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Language_options> Language_options { get; set; }
    }
}
