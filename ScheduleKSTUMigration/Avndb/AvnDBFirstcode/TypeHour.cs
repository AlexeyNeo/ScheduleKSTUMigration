namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TypeHour")]
    public partial class TypeHour
    {
        [Key]
        public int id_type_hour { get; set; }

        [StringLength(100)]
        public string n_type_hour { get; set; }
    }
}
