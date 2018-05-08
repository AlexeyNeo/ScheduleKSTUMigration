namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Organization")]
    public partial class Organization
    {
        [Key]
        public int id_organization { get; set; }

        [StringLength(20)]
        public string short_name { get; set; }

        [StringLength(400)]
        public string full_name { get; set; }
    }
}
