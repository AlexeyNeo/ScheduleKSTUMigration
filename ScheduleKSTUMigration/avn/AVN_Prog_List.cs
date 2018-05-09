namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AVN_Prog_List
    {
        [Key]
        public int id_prog_list { get; set; }

        [StringLength(50)]
        public string id_prog_id { get; set; }

        [StringLength(100)]
        public string description { get; set; }

        public int? version { get; set; }
    }
}
