namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Z_nauka1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_teacher { get; set; }

        [StringLength(152)]
        public string t_fio { get; set; }

        [StringLength(50)]
        public string k5 { get; set; }

        [StringLength(20)]
        public string spec_code { get; set; }

        public short? yearProtection { get; set; }

        [StringLength(200)]
        public string theme { get; set; }
    }
}
