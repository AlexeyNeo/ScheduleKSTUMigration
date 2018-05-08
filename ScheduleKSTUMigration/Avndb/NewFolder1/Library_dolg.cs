namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Library_dolg
    {
        [Key]
        public int id_library_dolg { get; set; }

        public int? id_st_tech { get; set; }

        [Column("Library_dolg")]
        public int? Library_dolg1 { get; set; }

        public int? s_t { get; set; }
    }
}
