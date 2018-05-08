namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vakansii")]
    public partial class Vakansii
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vakansii()
        {
            Workings = new HashSet<Working>();
        }

        [Key]
        public int id_vakansiya { get; set; }

        public int? id_otdel_1 { get; set; }

        public int? id_otdel_11 { get; set; }

        public int? id_faculty { get; set; }

        public int? id_otdel_2 { get; set; }

        public int? id_kafedra { get; set; }

        public int id_structure { get; set; }

        public int id_bk { get; set; }

        public int id_post { get; set; }

        public float q_units { get; set; }

        [Column(TypeName = "numeric")]
        public decimal razrad { get; set; }

        public int? Num { get; set; }

        public int id_enter { get; set; }

        [StringLength(30)]
        public string e_n_p { get; set; }

        public DateTime? e_d_p { get; set; }

        public int id_deduce { get; set; }

        [StringLength(30)]
        public string d_n_p { get; set; }

        public DateTime? d_d_p { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public double? hourFond { get; set; }

        [Column(TypeName = "ntext")]
        public string descr { get; set; }

        public int? id_o_z { get; set; }

        public virtual deduce deduce { get; set; }

        public virtual enter enter { get; set; }

        public virtual Otdel_1 Otdel_1 { get; set; }

        public virtual Otdel_1 Otdel_11 { get; set; }

        public virtual Otdel_1 Otdel_12 { get; set; }

        public virtual post post { get; set; }

        public virtual structure structure { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Working> Workings { get; set; }
    }
}
