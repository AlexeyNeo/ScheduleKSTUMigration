namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class abit_razryd
    {
        [Key]
        public int id_abit_razryd { get; set; }

        [Column("abit_razryd")]
        [StringLength(255)]
        public string abit_razryd1 { get; set; }
    }
}
