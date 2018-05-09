namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pay_educ_leta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_pay_educ_L { get; set; }

        public int? id_usluga { get; set; }
    }
}
