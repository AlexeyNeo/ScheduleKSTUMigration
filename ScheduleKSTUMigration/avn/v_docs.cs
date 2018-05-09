namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_docs
    {
        [Key]
        public int id_v_docs { get; set; }

        [Required]
        [StringLength(1)]
        public string code_docs { get; set; }

        [Required]
        [StringLength(30)]
        public string name_docs { get; set; }
    }
}
