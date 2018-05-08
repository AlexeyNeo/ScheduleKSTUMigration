namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class s_fio_birth
    {
        [Key]
        public int id_student { get; set; }

        [StringLength(90)]
        public string s_fio { get; set; }
    }
}
