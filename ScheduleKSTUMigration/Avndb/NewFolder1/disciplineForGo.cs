namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("disciplineForGos")]
    public partial class disciplineForGo
    {
        [Key]
        public int id_disciplina_GOS { get; set; }

        public int? id_discipline { get; set; }
    }
}