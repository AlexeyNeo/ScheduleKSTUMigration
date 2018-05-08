namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class f3_1
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_a_year { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_special { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string p32 { get; set; }

        [Column("p25-1")]
        [StringLength(50)]
        public string p25_1 { get; set; }

        [Column("p25-2")]
        [StringLength(300)]
        public string p25_2 { get; set; }
    }
}
