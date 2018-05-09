namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Educ_sh_sel
    {
        [Key]
        public int id_educ_sh_sel { get; set; }

        public int? id_speciality { get; set; }

        public int? id_a_year { get; set; }

        public int? id_semester { get; set; }

        public int? id_disciplineName { get; set; }

        public bool? isDeletable { get; set; }

        [StringLength(50)]
        public string avn_user { get; set; }

        public DateTime? avn_update { get; set; }
    }
}
