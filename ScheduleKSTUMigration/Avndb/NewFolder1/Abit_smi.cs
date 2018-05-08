namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Abit_smi
    {
        [Key]
        public int id_smi { get; set; }

        [StringLength(100)]
        public string Smi { get; set; }
    }
}
