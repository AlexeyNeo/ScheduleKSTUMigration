namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mm_kor_5
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ret { get; set; }
    }
}