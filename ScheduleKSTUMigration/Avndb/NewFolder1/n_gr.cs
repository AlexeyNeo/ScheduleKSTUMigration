namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class n_gr
    {
        [Key]
        [Column(Order = 0)]
        public int id_n_gr { get; set; }

        [Key]
        [Column("n_gr", Order = 1)]
        [StringLength(10)]
        public string n_gr1 { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }
    }
}
