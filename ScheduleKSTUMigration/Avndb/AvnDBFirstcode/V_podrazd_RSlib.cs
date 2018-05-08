namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_podrazd_RSlib
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_teacher { get; set; }

        [StringLength(152)]
        public string t_fio { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_leave { get; set; }

        [StringLength(80)]
        public string otd1 { get; set; }

        [StringLength(80)]
        public string otd11 { get; set; }

        [Column("p23-1")]
        [StringLength(50)]
        public string p23_1 { get; set; }

        [StringLength(300)]
        public string f1 { get; set; }
    }
}
