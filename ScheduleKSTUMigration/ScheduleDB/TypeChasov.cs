namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TypeChasov")]
    public partial class TypeChasov
    {
        [Key]
        public int id_type_chasov { get; set; }

        [StringLength(50)]
        public string n_type_chasov { get; set; }

        [StringLength(50)]
        public string short_name { get; set; }
    }
}
