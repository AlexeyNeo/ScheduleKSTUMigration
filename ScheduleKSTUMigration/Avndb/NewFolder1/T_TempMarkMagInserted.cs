namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_TempMarkMagInserted
    {
        public long id { get; set; }

        public int id_mark_mag { get; set; }

        public int? id_ebe_var { get; set; }

        public int? id_faculty { get; set; }

        public int? id_a_year { get; set; }

        public int? id_bk { get; set; }

        [StringLength(100)]
        public string Suser { get; set; }

        public DateTime? updata { get; set; }
    }
}
