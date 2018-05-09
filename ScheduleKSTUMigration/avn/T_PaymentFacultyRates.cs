namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_PaymentFacultyRates
    {
        [Key]
        public short id_paymentFacultyRate { get; set; }

        public int id_faculty { get; set; }

        public int id_rate { get; set; }
    }
}
