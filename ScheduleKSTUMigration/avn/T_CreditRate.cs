namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_CreditRate
    {
        [Key]
        public int id_creditRate { get; set; }

        public int id_a_year { get; set; }

        public int id_rate { get; set; }

        public int id_faculty { get; set; }

        public int id_speciality { get; set; }

        public int id_country { get; set; }

        public double sumPerCredit { get; set; }

        public DateTime? created { get; set; }
    }
}
