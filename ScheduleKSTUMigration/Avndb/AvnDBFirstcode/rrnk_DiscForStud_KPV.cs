namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rrnk_DiscForStud_KPV
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kafedra { get; set; }

        public int? id_a_year { get; set; }

        public int? id_semester { get; set; }

        public int? id_discipline { get; set; }

        public int? id_examination { get; set; }

        public int? kol_st_gr_all { get; set; }

        public int? kol_st_gr_all_b { get; set; }

        public int? o_z { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int isKPV { get; set; }

        public int? id_teacher { get; set; }

        public byte? subgroup { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_w_s { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_f_educ { get; set; }
    }
}
