namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class View_2
    {
        [StringLength(50)]
        public string login { get; set; }

        [StringLength(501)]
        public string Expr3 { get; set; }

        [Key]
        public int id_student { get; set; }
    }
}
