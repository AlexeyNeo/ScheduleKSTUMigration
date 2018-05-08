namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_MarkMag_user
    {
        public int? id_f_est { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string p109 { get; set; }

        public int? avn13 { get; set; }

        [Key]
        [Column(Order = 1)]
        public bool isPersonal { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_user_f_est { get; set; }

        public int? id_login { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(200)]
        public string AVN_login { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(101)]
        public string AVN_User { get; set; }
    }
}
