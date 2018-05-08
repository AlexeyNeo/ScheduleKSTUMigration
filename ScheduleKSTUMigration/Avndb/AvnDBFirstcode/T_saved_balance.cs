namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_saved_balance
    {
        [Key]
        public int id_saved_balance { get; set; }

        public int? id_a_year { get; set; }

        public int? id_faculty { get; set; }

        public int? id_rate { get; set; }

        public int? id_ws { get; set; }

        public double? sum_balance { get; set; }

        [Column(TypeName = "date")]
        public DateTime? saved_date { get; set; }

        [StringLength(15)]
        public string AVN_user { get; set; }

        [Column(TypeName = "date")]
        public DateTime? AVN_update { get; set; }

        public int? var { get; set; }

        public int? id_bk { get; set; }
    }
}
