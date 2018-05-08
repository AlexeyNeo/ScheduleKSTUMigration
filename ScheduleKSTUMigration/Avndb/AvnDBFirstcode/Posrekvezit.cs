namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Posrekvezit")]
    public partial class Posrekvezit
    {
        [Key]
        public int id_posrekvezit { get; set; }

        [StringLength(50)]
        public string code_discipline { get; set; }

        [StringLength(50)]
        public string post_code_discipline { get; set; }
    }
}
