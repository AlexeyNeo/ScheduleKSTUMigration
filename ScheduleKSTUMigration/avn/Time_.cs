namespace ScheduleKSTUMigration.avn
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
            Bronya = new HashSet<Bronya>();
            SemestrShcedule = new HashSet<SemestrShcedule>();
            Shcedule = new HashSet<Shcedule>();
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
        public virtual ICollection<Bronya> Bronya { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SemestrShcedule> SemestrShcedule { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Shcedule> Shcedule { get; set; }
    }
}
