namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class v_StreamGroup
    {
        [StringLength(64)]
        public string potok { get; set; }

        public int? Kod_gruppy { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        public int? id_a_year { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_w_s { get; set; }
    }
}
