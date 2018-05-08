namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VisibleRecTable")]
    public partial class VisibleRecTable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_visibleRecTable { get; set; }

        [StringLength(10)]
        public string n_visible_rec_table { get; set; }
    }
}
