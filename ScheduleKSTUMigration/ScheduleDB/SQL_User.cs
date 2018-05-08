namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SQL_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SQL_User()
        {
            AVN_Security = new HashSet<AVN_Security>();
        }

        [Key]
        public int id_SQL_user { get; set; }

        [StringLength(20)]
        public string SQL_login { get; set; }

        [StringLength(20)]
        public string SQL_password { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public int? temp { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AVN_Security> AVN_Security { get; set; }
    }
}
