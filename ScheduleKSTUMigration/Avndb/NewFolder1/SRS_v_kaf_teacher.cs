namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SRS_v_kaf_teacher
    {
        [StringLength(152)]
        public string t_fio { get; set; }

        public int? id_teacher { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kafedra { get; set; }
    }
}