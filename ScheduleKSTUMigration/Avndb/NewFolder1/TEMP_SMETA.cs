namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TEMP_SMETA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sum { get; set; }

        public int? id_bk { get; set; }
    }
}
