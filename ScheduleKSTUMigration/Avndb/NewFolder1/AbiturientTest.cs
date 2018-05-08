namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AbiturientTest")]
    public partial class AbiturientTest
    {
        [Key]
        public int id_abiturient_test { get; set; }

        public int id_abiturient { get; set; }

        public int id_school_discipline { get; set; }

        public short? result { get; set; }
    }
}
