namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Del_DisciplineForStudent
    {
        [Key]
        public int id_del_disciplineForStudent { get; set; }

        public int? id_disciplineForStudent { get; set; }

        public int? id_student { get; set; }

        public int? id_discipline { get; set; }

        public int? id_semester { get; set; }

        public int? id_teacher { get; set; }

        public int? subgroup { get; set; }

        public int? id_group { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public int? id_examination { get; set; }

        public int? id_a_year { get; set; }

        public int? id_ins_year { get; set; }

        public int? id_ins_semester { get; set; }

        public int? descGroupNum { get; set; }

        public int? id_disciplineName { get; set; }

        public int id_kafedra { get; set; }

        public bool isByPlan { get; set; }

        public int id_vid_zaniatiy { get; set; }

        public int kredits { get; set; }

        public int id_faculty { get; set; }
    }
}
