namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vedomost_akadem
    {
        [Key]
        public int id_vedomost_akadem { get; set; }

        public int id_group { get; set; }

        public int id_student { get; set; }

        public int id_disipline { get; set; }

        public int id_examination { get; set; }

        public int id_semester { get; set; }

        public int kredits { get; set; }

        public int id_teacher { get; set; }
    }
}
