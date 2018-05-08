namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class exp_dipl
    {
        public int? id_uslug { get; set; }

        [Key]
        [Column(Order = 0)]
        public double exp_p102 { get; set; }

        public int? id_student { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime p103 { get; set; }
    }
}
