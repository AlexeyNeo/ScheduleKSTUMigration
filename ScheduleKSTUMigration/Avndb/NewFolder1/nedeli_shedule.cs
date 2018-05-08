namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class nedeli_shedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_nedel_shedule { get; set; }

        public int? num_nedeli { get; set; }
    }
}
