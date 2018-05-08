namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("teemp")]
    public partial class teemp
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_protocols { get; set; }

        public DateTime? u_date { get; set; }
    }
}
