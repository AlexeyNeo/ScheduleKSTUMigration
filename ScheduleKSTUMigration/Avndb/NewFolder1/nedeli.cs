namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nedeli")]
    public partial class nedeli
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public nedeli()
        {
            SemestrShcedules = new HashSet<SemestrShcedule>();
        }

        [Key]
        public int id_nedeli { get; set; }

        public int? id_w_s { get; set; }

        public int? num_nedeli { get; set; }

        public int? Chislitel_Znamenatel { get; set; }

        public virtual w_s w_s { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SemestrShcedule> SemestrShcedules { get; set; }
    }
}
