namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Lookup_S_FIO_slushatel
    {
        public int? id_student { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string p1 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string p2 { get; set; }

        public int? id_faculty { get; set; }

        [StringLength(102)]
        public string s_fio { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_AVN_user { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_group_slushatel { get; set; }

        [StringLength(20)]
        public string name_short { get; set; }
    }
}
