namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KafSecurity")]
    public partial class KafSecurity
    {
        [Key]
        public int id_kafSecurity { get; set; }

        public int? id_kafLogin { get; set; }

        public int? id_kafedra { get; set; }

        public virtual kafedra kafedra { get; set; }

        public virtual kafLogins kafLogins { get; set; }
    }
}
