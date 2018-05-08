namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class movement_slushatel
    {
        [Key]
        public int id_movement_slushatel { get; set; }

        public int? id_student { get; set; }

        public int? id_group_slushatel { get; set; }

        public int? id_prikaz_come_slushatel { get; set; }

        public DateTime? come_date { get; set; }

        public int? id_prikaz_leave_slushatel { get; set; }

        public DateTime? leave_date { get; set; }

        [StringLength(15)]
        public string come_reg { get; set; }

        [StringLength(15)]
        public string leave_reg { get; set; }
    }
}
