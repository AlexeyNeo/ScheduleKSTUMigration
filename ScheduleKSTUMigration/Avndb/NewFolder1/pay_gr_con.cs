namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pay_gr_con
    {
        [Key]
        public int id_pay_gr_con { get; set; }

        public int id_fak { get; set; }

        public int id_pay_group { get; set; }
    }
}
