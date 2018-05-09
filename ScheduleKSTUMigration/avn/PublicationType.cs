namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PublicationType")]
    public partial class PublicationType
    {
        [Key]
        public int id_publicationType { get; set; }

        [Column("publicationType")]
        [StringLength(100)]
        public string publicationType1 { get; set; }
    }
}
