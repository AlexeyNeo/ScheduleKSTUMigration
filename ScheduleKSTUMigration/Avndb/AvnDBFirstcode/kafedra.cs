namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("kafedra")]
    public partial class kafedra
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public kafedra()
        {
            com_kt = new HashSet<com_kt>();
            directions = new HashSet<direction>();
            educ_sh = new HashSet<educ_sh>();
            KafSecurities = new HashSet<KafSecurity>();
        }

        [Key]
        public int id_kafedra { get; set; }

        [StringLength(300)]
        public string f1 { get; set; }

        [StringLength(50)]
        public string sn_f1 { get; set; }

        [StringLength(10)]
        public string login { get; set; }

        [StringLength(15)]
        public string pswd { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public int? id_kaf { get; set; }

        public int? id_rrnkcalc { get; set; }

        public int? id_faculty { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<com_kt> com_kt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<direction> directions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<educ_sh> educ_sh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KafSecurity> KafSecurities { get; set; }
    }
}
