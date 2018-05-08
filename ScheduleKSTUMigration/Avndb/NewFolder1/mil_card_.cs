namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mil_card_
    {
        [Key]
        public int id_mil_card { get; set; }

        public int? id_mil_name { get; set; }

        public int? id_valid { get; set; }

        [StringLength(50)]
        public string voencom { get; set; }

        public int? id_R_voisk { get; set; }

        [StringLength(50)]
        public string Sostav { get; set; }

        public int? id_teacher { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public bool? Voinsk_uchet { get; set; }

        [StringLength(250)]
        public string Vus { get; set; }

        public virtual Mil_name Mil_name { get; set; }

        public virtual Mil_R_Voisk Mil_R_Voisk { get; set; }

        public virtual Mil_valid Mil_valid { get; set; }

        public virtual teacher teacher { get; set; }
    }
}
