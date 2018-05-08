namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Kredit_fakulty
    {
        [Key]
        public int id_kredit { get; set; }

        public int? id_fakulty { get; set; }

        public float? kredit { get; set; }
    }
}
