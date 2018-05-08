namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class f_AVN28_sem
    {
        public int? id_teacher { get; set; }

        public int? id_a_year { get; set; }

        public int? id_sem { get; set; }

        public int? id_login { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string sem { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int isSelect { get; set; }

        public int? ws_sort { get; set; }
    }
}
