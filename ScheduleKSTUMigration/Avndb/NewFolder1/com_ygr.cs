namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class com_ygr
    {
        [Key]
        public int id_com_ygr { get; set; }

        public int id_a_year { get; set; }

        public int id_group_y { get; set; }

        public int id_rate { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public virtual a_year a_year { get; set; }

        public virtual rate rate { get; set; }
    }
}
