namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ST_23
    {
        public int? id_otdel_1 { get; set; }

        public int? id_otdel_2 { get; set; }

        public int? id_kafedra { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_post { get; set; }

        [Key]
        [Column(Order = 1)]
        public int id_vakansiya { get; set; }

        public int? id_faculty { get; set; }

        [Key]
        [Column(Order = 2)]
        public float empty_vacation { get; set; }
    }
}
