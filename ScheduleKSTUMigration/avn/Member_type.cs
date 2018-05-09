namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Member_type
    {
        [Key]
        public int id_member_type { get; set; }

        [Column("member_type")]
        [StringLength(150)]
        public string member_type1 { get; set; }
    }
}
