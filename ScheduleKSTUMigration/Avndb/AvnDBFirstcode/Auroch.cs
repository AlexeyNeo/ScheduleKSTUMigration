namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Aurochs")]
    public partial class Auroch
    {
        [Key]
        public int id_aurochs { get; set; }

        public byte? num { get; set; }

        public int? id_a_year { get; set; }

        public int? id_bk { get; set; }

        public DateTime? beg_date { get; set; }

        public DateTime? end_date { get; set; }

        public DateTime? AVN_update { get; set; }

        [StringLength(250)]
        public string host { get; set; }
    }
}
