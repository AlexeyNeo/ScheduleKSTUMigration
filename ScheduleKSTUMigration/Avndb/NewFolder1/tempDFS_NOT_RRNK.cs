namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tempDFS_NOT_RRNK
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_disciplineForStudent { get; set; }
    }
}
