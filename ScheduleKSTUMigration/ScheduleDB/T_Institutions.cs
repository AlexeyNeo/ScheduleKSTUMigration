namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Institutions
    {
        [Key]
        [Column(Order = 0)]
        public int id_institution { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_country { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string name { get; set; }
    }
}
