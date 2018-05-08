namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tempDFS")]
    public partial class tempDF
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_disciplineForStudent { get; set; }

        public DateTime? AVN_update { get; set; }
    }
}
