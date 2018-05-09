namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class akad_grafik
    {
        [Key]
        public int id_akad_grafik { get; set; }

        public int? id_year { get; set; }

        public DateTime? KT_osen_beg { get; set; }

        public DateTime? KT_osen_end { get; set; }

        public DateTime? RK_osen_beg { get; set; }

        public DateTime? RK_osen_end { get; set; }

        public DateTime? KT_vesen_beg { get; set; }

        public DateTime? KT_vesen_end { get; set; }

        public DateTime? RK_vesen_beg { get; set; }

        public DateTime? RK_vesen_end { get; set; }

        public DateTime? letnii_beg { get; set; }

        public DateTime? letnii_end { get; set; }
    }
}
