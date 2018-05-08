namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("__s_g_mirror")]
    public partial class C__s_g_mirror
    {
        [Key]
        public int id_mirror_s_g { get; set; }

        public int? id_student { get; set; }

        public int? id_group { get; set; }

        public int? id_bk { get; set; }

        public int? id_semester { get; set; }

        public int? id_start_semester { get; set; }
    }
}
