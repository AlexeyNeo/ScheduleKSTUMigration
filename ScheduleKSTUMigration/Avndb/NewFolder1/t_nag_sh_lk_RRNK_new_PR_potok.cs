namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_nag_sh_lk_RRNK_new_PR_potok
    {
        public int? id_year { get; set; }

        public int? id_kafedra { get; set; }

        public int? id_teacher { get; set; }

        public int? id_discipline { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int subgroup { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int prov_reyt { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(6)]
        public string AVN_user { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime AVN_update { get; set; }

        public int? id_examination { get; set; }

        public int? id_w_s { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int plan_fakt { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_o_z { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_ebe_var { get; set; }

        public int? id_vid_zaniatiy { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_f_educ { get; set; }

        public int? kredit { get; set; }
    }
}
