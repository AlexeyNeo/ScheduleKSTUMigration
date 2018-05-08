namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class var_sum
    {
        [Key]
        public int id_var_sum { get; set; }

        public int? id_ebe_var { get; set; }

        [Column("var_sum")]
        public int? var_sum1 { get; set; }

        public int? var_prog { get; set; }

        [StringLength(10)]
        public string prog { get; set; }
    }
}
