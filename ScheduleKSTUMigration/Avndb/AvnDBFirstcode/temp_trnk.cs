namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temp_trnk
    {
        [Key]
        [Column(Order = 0)]
        public int id_faculty { get; set; }

        [StringLength(20)]
        public string id_ua { get; set; }

        [Key]
        [Column("p23-1", Order = 1)]
        [StringLength(50)]
        public string p23_1 { get; set; }

        [Key]
        [Column("p23-2", Order = 2)]
        [StringLength(100)]
        public string p23_2 { get; set; }
    }
}
