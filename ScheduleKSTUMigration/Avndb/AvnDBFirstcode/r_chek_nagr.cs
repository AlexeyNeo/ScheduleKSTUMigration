namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class r_chek_nagr
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_a_year { get; set; }

        public int? o_z { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_w_s { get; set; }

        [StringLength(50)]
        public string sn_f1 { get; set; }

        [StringLength(10)]
        public string s_p34 { get; set; }

        public int? Krdt { get; set; }

        public double? p51 { get; set; }

        public double? p52 { get; set; }

        public double? p53 { get; set; }

        [StringLength(55)]
        public string s_t_fio { get; set; }

        [StringLength(10)]
        public string potok { get; set; }

        [StringLength(50)]
        public string short_name { get; set; }

        public int? id_vid_zaniatiy { get; set; }

        public int? kol_b { get; set; }

        public int? kol_k { get; set; }

        public int? kol_st { get; set; }

        [StringLength(300)]
        public string p34 { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kafedra { get; set; }
    }
}
