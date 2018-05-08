namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pay_st
    {
        public int? id_a_year { get; set; }

        public int? id_group { get; set; }

        public int? id_rate { get; set; }

        public int? id_student { get; set; }

        [Key]
        public DateTime p103 { get; set; }

        public double? p102 { get; set; }
    }
}
