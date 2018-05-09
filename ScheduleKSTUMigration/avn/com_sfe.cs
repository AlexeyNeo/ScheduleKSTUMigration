namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_sfe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public com_sfe()
        {
            com_gspe = new HashSet<com_gspe>();
            educ_sh = new HashSet<educ_sh>();
            movement_t = new HashSet<movement_t>();
            plan_abit = new HashSet<plan_abit>();
            smeta = new HashSet<smeta>();
        }

        [Key]
        public int id_speciality { get; set; }

        public int id_special { get; set; }

        public int id_f_educ { get; set; }

        public int id_faculty { get; set; }

        public int? id_kafedra { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public bool? visible { get; set; }

        public int? id_ebe_var { get; set; }

        public int? id_obem_chasov { get; set; }

        [StringLength(20)]
        public string code_spec { get; set; }

        public int? IDLicence { get; set; }

        public double? Apprenticeship { get; set; }

        public int? id_standard { get; set; }

        public int? id_qualification { get; set; }

        public int? id_direction { get; set; }

        public int ORT_biology { get; set; }

        public int ORT_history { get; set; }

        public int ORT_chemistry { get; set; }

        public int ORT_physics { get; set; }

        public int ORT_english { get; set; }

        public int ORT_math { get; set; }

        public int? ORT_dop_test { get; set; }

        public int ORT_contrak { get; set; }

        public int ORT_butjet { get; set; }

        public int? P_ORT_chemistry { get; set; }

        public int? P_ORT_biology { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<com_gspe> com_gspe { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<educ_sh> educ_sh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<movement_t> movement_t { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<plan_abit> plan_abit { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<smeta> smeta { get; set; }
    }
}
