namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ObemChasov")]
    public partial class ObemChasov
    {
        [Key]
        public int id_obem_chasov { get; set; }

        [StringLength(20)]
        public string n_obem_chasov { get; set; }
    }
}
