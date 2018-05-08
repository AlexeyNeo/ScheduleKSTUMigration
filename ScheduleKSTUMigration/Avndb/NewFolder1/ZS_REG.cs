namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ZS_REG
    {
        public int? id_a_year { get; set; }

        public int? id_w_s { get; set; }

        public int? id_semester { get; set; }

        public int? id_group { get; set; }

        public int? id_student { get; set; }

        public int? id_discipline { get; set; }

        public int? id_examination { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kredits { get; set; }

        public int? id_teacher { get; set; }
    }
}
