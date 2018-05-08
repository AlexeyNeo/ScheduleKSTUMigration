namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bank_akt_sverka
    {
        public int? MONTH { get; set; }

        public double? Expr1 { get; set; }

        public int? Expr2 { get; set; }

        [Key]
        public bool isCanceled { get; set; }
    }
}
