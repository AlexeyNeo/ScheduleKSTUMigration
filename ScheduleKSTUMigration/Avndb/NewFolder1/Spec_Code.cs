namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Spec_Code
    {
        [Key]
        public int id_spec_code { get; set; }

        [Column("spec_code")]
        [StringLength(20)]
        public string spec_code1 { get; set; }
    }
}
