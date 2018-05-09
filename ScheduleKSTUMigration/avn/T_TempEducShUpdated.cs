namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_TempEducShUpdated
    {
        public long id { get; set; }

        public int id_educ_sh { get; set; }

        public int? id_speciality { get; set; }

        public int? id_a_year { get; set; }

        public int? id_semester { get; set; }

        public int? id_discipline { get; set; }

        public int? id_examination { get; set; }

        public int? Krdt { get; set; }

        public bool? isSelect { get; set; }

        public int? id_kafedra { get; set; }

        [StringLength(100)]
        public string Suser { get; set; }

        public DateTime? updata { get; set; }
    }
}
