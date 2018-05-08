namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Anket_RRNK_kaf
    {
        public int? id_a_year { get; set; }

        public int? id_w_s { get; set; }

        public int? id_teacher { get; set; }

        public int? id_discipline { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kafedra { get; set; }
    }
}
