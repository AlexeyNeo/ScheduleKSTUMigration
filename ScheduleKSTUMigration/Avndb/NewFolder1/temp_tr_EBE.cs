namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temp_tr_EBE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_mark_mag { get; set; }

        public int? id_ebe_var { get; set; }

        public int? ebe { get; set; }
    }
}
