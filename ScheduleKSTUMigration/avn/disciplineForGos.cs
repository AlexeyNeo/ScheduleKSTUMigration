namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class disciplineForGos
    {
        [Key]
        public int id_disciplina_GOS { get; set; }

        public int? id_discipline { get; set; }
    }
}
