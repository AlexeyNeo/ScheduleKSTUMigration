namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_nag_sh_lb_update
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_shcedule { get; set; }

        public int? old_id_rrnk { get; set; }

        public int? new_id_rrnk { get; set; }
    }
}
