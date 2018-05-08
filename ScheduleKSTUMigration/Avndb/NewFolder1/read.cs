namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("read")]
    public partial class read
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_read { get; set; }
    }
}
