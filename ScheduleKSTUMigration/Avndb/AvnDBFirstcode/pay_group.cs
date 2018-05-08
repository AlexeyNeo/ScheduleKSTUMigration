namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class pay_group
    {
        [Key]
        public int id_pay_group { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string name_gr { get; set; }
    }
}
