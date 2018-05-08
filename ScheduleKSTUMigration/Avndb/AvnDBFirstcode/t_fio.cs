namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_fio
    {
        [Key]
        [Column(Order = 0)]
        public int id_teacher { get; set; }

        [Key]
        [Column("t_fio", Order = 1)]
        [StringLength(152)]
        public string t_fio1 { get; set; }

        [StringLength(55)]
        public string s_t_fio { get; set; }
    }
}
