namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class p3
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_vakansiya { get; set; }

        public double? svob { get; set; }
    }
}
