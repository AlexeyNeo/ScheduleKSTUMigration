namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_CreditSmetaBudgetContract
    {
        [Key]
        public long id_creditSmeta { get; set; }

        public int id_a_year { get; set; }

        public int id_rate { get; set; }

        public int id_w_s { get; set; }

        public int id_student { get; set; }

        public int id_group { get; set; }

        public int id_uslug { get; set; }

        public int sum { get; set; }
    }
}
