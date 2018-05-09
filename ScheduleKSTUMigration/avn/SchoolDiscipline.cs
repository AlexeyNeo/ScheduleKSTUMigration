namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SchoolDiscipline")]
    public partial class SchoolDiscipline
    {
        [Key]
        public int id_school_discipline { get; set; }

        [StringLength(20)]
        public string n_school_discipline { get; set; }
    }
}
