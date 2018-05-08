namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("zanyat")]
    public partial class zanyat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_vakansiya { get; set; }

        [Column("zanyat")]
        public double? zanyat1 { get; set; }
    }
}
