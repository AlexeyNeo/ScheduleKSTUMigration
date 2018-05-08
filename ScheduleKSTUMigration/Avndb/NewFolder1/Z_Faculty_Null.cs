namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Z_Faculty_Null
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_InfoOnEdIns { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDStudent { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(152)]
        public string ab_fio { get; set; }

        [StringLength(25)]
        public string NumberSertRT { get; set; }

        public int? Faculties { get; set; }

        public DateTime? AVN_update { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(15)]
        public string name { get; set; }
    }
}
