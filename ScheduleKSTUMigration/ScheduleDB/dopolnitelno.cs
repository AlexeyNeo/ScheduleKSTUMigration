namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dopolnitelno")]
    public partial class dopolnitelno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_dopolnitelno { get; set; }

        [StringLength(200)]
        public string insert_pole { get; set; }

        [StringLength(200)]
        public string insert_pole_kg { get; set; }

        [StringLength(200)]
        public string coment { get; set; }
    }
}
