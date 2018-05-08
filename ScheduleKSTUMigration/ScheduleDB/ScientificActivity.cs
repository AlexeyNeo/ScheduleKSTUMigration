namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ScientificActivity")]
    public partial class ScientificActivity
    {
        [Key]
        public int id_ScientificActivity { get; set; }

        public int? id_t_fio { get; set; }

        public int? id_uch_step { get; set; }

        public int? id_uch_zvanie { get; set; }

        public int? id_spec_code { get; set; }

        public short? yearProtection { get; set; }

        [StringLength(200)]
        public string theme { get; set; }

        [StringLength(300)]
        public string val1 { get; set; }

        [StringLength(300)]
        public string val2 { get; set; }

        [StringLength(300)]
        public string val3 { get; set; }
    }
}
