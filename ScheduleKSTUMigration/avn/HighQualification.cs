namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HighQualification")]
    public partial class HighQualification
    {
        [Key]
        public int id_qualification { get; set; }

        [StringLength(20)]
        public string qualification { get; set; }
    }
}
