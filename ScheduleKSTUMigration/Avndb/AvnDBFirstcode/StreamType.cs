namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StreamType")]
    public partial class StreamType
    {
        [Key]
        public int id_streamType { get; set; }

        [Column("streamType")]
        [StringLength(50)]
        public string streamType1 { get; set; }
    }
}
