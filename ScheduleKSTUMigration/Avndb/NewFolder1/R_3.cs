namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class R_3
    {
        public int? id_a_year { get; set; }

        public int? id_w_s { get; set; }

        public int? id_teacher { get; set; }

        public int? id_discipline { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sel { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kredit { get; set; }

        public int? id_o_z { get; set; }

        public int? id_kafedra { get; set; }
    }
}
