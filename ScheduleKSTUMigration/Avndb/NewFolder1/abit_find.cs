namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class abit_find
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDStudent { get; set; }

        public int? Faculties { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool Takebackdocs { get; set; }

        [Key]
        [Column(Order = 2)]
        public byte tour { get; set; }
    }
}