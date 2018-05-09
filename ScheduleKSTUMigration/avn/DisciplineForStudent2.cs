namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DisciplineForStudent2
    {
        [Key]
        public int id_disciplineForStudent2 { get; set; }

        public int? id_student { get; set; }

        public int? id_educ_sh_discipline { get; set; }

        public int? id_semester { get; set; }

        public int? id_a_year { get; set; }

        public int? subgroup { get; set; }

        public int? id_discipline { get; set; }

        public int? id_teacher { get; set; }
    }
}
