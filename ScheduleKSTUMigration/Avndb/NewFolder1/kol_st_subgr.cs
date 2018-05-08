namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class kol_st_subgr
    {
        public int? id_a_year { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kafedra { get; set; }

        public int? id_teacher { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_w_s { get; set; }

        public byte? subgroup { get; set; }

        public int? id_discipline { get; set; }

        public int? id_examination { get; set; }

        public long? kol_st { get; set; }

        public double? p51 { get; set; }

        public double? p52 { get; set; }

        public double? p53 { get; set; }

        public double? seminar { get; set; }

        public double? srs { get; set; }

        public double? rzr { get; set; }

        public double? ind_z { get; set; }

        public double? p54 { get; set; }

        public int? o_z { get; set; }
    }
}
