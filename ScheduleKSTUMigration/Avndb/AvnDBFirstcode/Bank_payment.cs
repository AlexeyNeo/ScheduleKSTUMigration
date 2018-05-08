namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Bank_payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_v_opl { get; set; }

        public int? month { get; set; }

        public double? Expr2 { get; set; }

        public int? Expr1 { get; set; }

        public int? Expr3 { get; set; }
    }
}
