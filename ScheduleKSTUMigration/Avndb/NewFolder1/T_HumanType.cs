namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_HumanType
    {
        [Key]
        public int id_humanType { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }
    }
}
