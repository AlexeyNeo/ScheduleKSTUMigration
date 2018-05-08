namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_LogActions
    {
        [Key]
        public int id_logAction { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }
    }
}
