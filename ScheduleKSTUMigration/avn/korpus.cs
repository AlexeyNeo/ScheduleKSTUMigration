namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class korpus
    {
        [Key]
        public int id_korpus { get; set; }

        [Required]
        [StringLength(100)]
        public string name_korpus { get; set; }

        [Required]
        [StringLength(50)]
        public string adress { get; set; }
    }
}
