namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupNotInRRNK")]
    public partial class GroupNotInRRNK
    {
        [Key]
        public int id_groupNotInRrnk { get; set; }

        public int id_rate { get; set; }

        public int id_group { get; set; }
    }
}
