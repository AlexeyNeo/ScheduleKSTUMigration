namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class modul_info
    {
        [Key]
        public int id_modul_info { get; set; }

        public byte? modul_num { get; set; }

        public bool? toCount { get; set; }
    }
}
