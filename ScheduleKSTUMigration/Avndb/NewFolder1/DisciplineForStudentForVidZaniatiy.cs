namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DisciplineForStudentForVidZaniatiy")]
    public partial class DisciplineForStudentForVidZaniatiy
    {
        [Key]
        public int id_disciplineForStudentForVidZaniatiy { get; set; }

        public int id_disciplineForStudent { get; set; }

        public int id_vid_zaniatiy { get; set; }

        public int id_teacher { get; set; }

        public int subgroup { get; set; }

        public int id_faculty { get; set; }
    }
}
