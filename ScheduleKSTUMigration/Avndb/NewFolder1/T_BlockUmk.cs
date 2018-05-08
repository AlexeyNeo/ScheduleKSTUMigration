namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_BlockUmk
    {
        [Key]
        public int id_blockUmk { get; set; }

        public int id_a_year { get; set; }

        public int id_w_s { get; set; }

        public DateTime endDate { get; set; }
    }
}
