namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Time_
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Time_()
        {
            Bronyas = new HashSet<Bronya>();
            SemestrShcedules = new HashSet<SemestrShcedule>();
            Shcedules = new HashSet<Shcedule>();
        }

        [Key]
        public int id_time { get; set; }

        [Column("Time_")]
        [StringLength(15)]
        public string Time_1 { get; set; }

        public int? sort { get; set; }

        public int? prov_time { get; set; }

        public int? vid_time { get; set; }

        [StringLength(15)]
        public string begin_time { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bronya> Bronyas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SemestrShcedule> SemestrShcedules { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shcedule> Shcedules { get; set; }
    }
}
