namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        [Key]
        public int id_category { get; set; }

        [StringLength(50)]
        public string n_category { get; set; }

        [StringLength(200)]
        public string for_stetment { get; set; }
    }
}
