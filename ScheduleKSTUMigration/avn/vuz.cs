namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("vuz")]
    public partial class vuz
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vuz()
        {
            faculty = new HashSet<faculty>();
        }

        [Key]
        public int id_vuz { get; set; }

        [Required]
        [StringLength(10)]
        public string v1 { get; set; }

        [Required]
        [StringLength(70)]
        public string v2 { get; set; }

        public int? id_ministerstvo { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [StringLength(100)]
        public string adres { get; set; }

        [StringLength(50)]
        public string v3 { get; set; }

        [StringLength(70)]
        public string glava { get; set; }

        [StringLength(150)]
        public string v2_k { get; set; }

        [StringLength(50)]
        public string tel { get; set; }

        [StringLength(50)]
        public string nomer_licen { get; set; }

        public DateTime? date_licen { get; set; }

        [StringLength(200)]
        public string v4 { get; set; }

        [StringLength(10)]
        public string v1_k { get; set; }

        [StringLength(50)]
        public string nomer_licen_kg { get; set; }

        [StringLength(100)]
        public string v5 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<faculty> faculty { get; set; }

        public virtual ministerstvo ministerstvo { get; set; }
    }
}
