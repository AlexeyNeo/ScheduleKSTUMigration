namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Modul")]
    public partial class Modul
    {
        [Key]
        public int id_modul { get; set; }

        [StringLength(25)]
        public string modulName { get; set; }

        [StringLength(50)]
        public string fieldName { get; set; }
    }
}
