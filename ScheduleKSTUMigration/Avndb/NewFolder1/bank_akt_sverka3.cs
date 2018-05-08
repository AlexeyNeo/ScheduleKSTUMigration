namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bank_akt_sverka3
    {
        [Key]
        [Column(Order = 0)]
        public DateTime txn_date { get; set; }

        [StringLength(100)]
        public string CODE { get; set; }

        [Key]
        [Column(Order = 1)]
        public float suma { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(77)]
        public string s_fio { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_uslug { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_student { get; set; }
    }
}
