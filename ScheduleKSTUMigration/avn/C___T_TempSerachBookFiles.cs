namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("___T_TempSerachBookFiles")]
    public partial class C___T_TempSerachBookFiles
    {
        public long id { get; set; }

        [Required]
        [StringLength(300)]
        public string item { get; set; }

        public int? id_books { get; set; }
    }
}
