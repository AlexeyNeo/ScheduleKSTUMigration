namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Admin_temp_online_payment
    {
        public int id { get; set; }

        [StringLength(150)]
        public string s_fio { get; set; }

        public int? id_rate { get; set; }

        public float? sum { get; set; }
    }
}
