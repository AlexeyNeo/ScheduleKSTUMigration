namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temp_copy_est_from_ebe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int est_mm { get; set; }

        public int? id_estimation { get; set; }
    }
}
