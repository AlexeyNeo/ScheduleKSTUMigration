namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SCHSchedule_discp_pasp
    {
        [Key]
        public int id_discip_rast { get; set; }

        [StringLength(150)]
        public string p34 { get; set; }

        [StringLength(50)]
        public string s_p34 { get; set; }

        [StringLength(50)]
        public string code_discipline { get; set; }

        [StringLength(50)]
        public string rasp_code_discipline { get; set; }

        [StringLength(150)]
        public string p34_kg { get; set; }
    }
}
