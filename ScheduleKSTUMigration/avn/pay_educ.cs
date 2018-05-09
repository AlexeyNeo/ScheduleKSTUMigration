namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pay_educ
    {
        [Key]
        public int id_pay_educ { get; set; }

        public int? id_uslug { get; set; }
    }
}
