namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Debt
    {
        [Key]
        public int id_debts { get; set; }

        public int? id_semester { get; set; }

        public int? id_student { get; set; }

        public int? id_discipline { get; set; }
    }
}
