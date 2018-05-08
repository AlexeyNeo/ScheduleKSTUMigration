namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("disciplineForZashita")]
    public partial class disciplineForZashita
    {
        [Key]
        public int id_disciplineForZashita { get; set; }

        public int? id_discipline { get; set; }
    }
}
