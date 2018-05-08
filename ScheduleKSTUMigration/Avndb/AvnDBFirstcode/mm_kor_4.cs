namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mm_kor_4
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int giv { get; set; }
    }
}
