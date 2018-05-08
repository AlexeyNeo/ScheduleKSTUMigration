namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rr_k_c
    {
        public int? id_a_year { get; set; }

        public int? id_kafedra { get; set; }

        [StringLength(571)]
        public string p20 { get; set; }

        [StringLength(203)]
        public string n_element { get; set; }

        public double? times { get; set; }

        public int? id_discipline { get; set; }

        public int? id_semester { get; set; }

        public int? id_examination { get; set; }

        public int? id_rrnk_elements { get; set; }

        [StringLength(50)]
        public string n_type_chasov { get; set; }

        public int? id_w_s { get; set; }

        public int? o_z { get; set; }

        public int? sort1 { get; set; }

        public int? id_umn { get; set; }

        public int? sort0 { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_speciality { get; set; }

        [StringLength(100)]
        public string forWhat { get; set; }

        public int? sort3 { get; set; }

        public int? id_f_educ_vid { get; set; }

        public int? Krdt { get; set; }

        public int? id_group { get; set; }
    }
}
