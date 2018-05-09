namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ToolTable")]
    public partial class ToolTable
    {
        [Key]
        public int IDRecord { get; set; }

        [StringLength(500)]
        public string InstituteName { get; set; }

        [StringLength(15)]
        public string InstituteSmallName { get; set; }

        [StringLength(255)]
        public string InstituteNameOf { get; set; }

        [StringLength(500)]
        public string RectorName { get; set; }

        [StringLength(500)]
        public string OperatorName { get; set; }

        [StringLength(500)]
        public string Minist { get; set; }
    }
}
