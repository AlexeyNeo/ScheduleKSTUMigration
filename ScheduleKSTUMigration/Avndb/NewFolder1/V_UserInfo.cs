namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_UserInfo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_AVN_user { get; set; }

        public int? id_language { get; set; }

        [StringLength(10)]
        public string locale { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(152)]
        public string snp { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool visible { get; set; }
    }
}
