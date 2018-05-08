namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class trnk_rs_naz
    {
        [StringLength(20)]
        public string id_ua { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_country { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string s_p14_7 { get; set; }

        public int? kol_st_b { get; set; }

        public int? kol_st_k { get; set; }

        public int? kol_st_m { get; set; }

        public int? kol_st_j { get; set; }

        public int? kol_st1 { get; set; }
    }
}
