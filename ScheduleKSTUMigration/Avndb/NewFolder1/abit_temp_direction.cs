namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class abit_temp_direction
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
        [Column("p23-1", Order = 2)]
        [StringLength(50)]
        public string p23_1 { get; set; }

        public int? id_direction { get; set; }

        [Column("p24-1")]
        [StringLength(50)]
        public string p24_1 { get; set; }

        [Column("p24-2")]
        [StringLength(300)]
        public string p24_2 { get; set; }
    }
}
