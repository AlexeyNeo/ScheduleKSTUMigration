namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("direction")]
    public partial class direction
    {
        [Key]
        public int id_direction { get; set; }

        public int? id_kafedra { get; set; }

        [Column("p24-1")]
        [StringLength(50)]
        public string p24_1 { get; set; }

        [Column("p24-2")]
        [StringLength(300)]
        public string p24_2 { get; set; }

        [StringLength(5)]
        public string oper { get; set; }

        public DateTime? u_date { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [Column("p24-2_kg")]
        [StringLength(300)]
        public string p24_2_kg { get; set; }

        public virtual kafedra kafedra { get; set; }
    }
}
