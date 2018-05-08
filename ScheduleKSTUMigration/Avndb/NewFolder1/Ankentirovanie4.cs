namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ankentirovanie4
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_teacher { get; set; }

        public int? id_a_year { get; set; }

        public int? id_discipline { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(300)]
        public string p34 { get; set; }

        public int? kredits { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_w_s { get; set; }

        public int? kol_reg_st { get; set; }

        [Column("4")]
        public int? C4 { get; set; }
    }
}
