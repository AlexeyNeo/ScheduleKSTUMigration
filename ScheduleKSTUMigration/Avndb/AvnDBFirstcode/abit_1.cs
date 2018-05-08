namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class abit_1
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [Key]
        [Column("p23-1", Order = 1)]
        [StringLength(50)]
        public string p23_1 { get; set; }

        public int? all_st { get; set; }

        public int? sert_st { get; set; }

        public int? st_budj { get; set; }

        public int? st_kontr { get; set; }

        public int? st_recom_b { get; set; }

        public int? st_recom_k { get; set; }

        public int? st_confirm_b { get; set; }

        public int? st_confirm_k { get; set; }

        public int? kol_b { get; set; }

        public int? kol_k { get; set; }

        public int? dz { get; set; }

        public int? bz_vh { get; set; }

        public int? bz_nevh { get; set; }

        [Key]
        [Column("p23-2", Order = 2)]
        [StringLength(100)]
        public string p23_2 { get; set; }
    }
}
