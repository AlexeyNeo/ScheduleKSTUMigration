namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lookup_S_FIO_Payment_old
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_student { get; set; }

        [StringLength(99)]
        public string s_fio { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(77)]
        public string s { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string p1 { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(25)]
        public string p2 { get; set; }

        public int? id_kassa { get; set; }

        [StringLength(25)]
        public string first_p1 { get; set; }
    }
}
