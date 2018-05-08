namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_OnlinePaymentPreparedAccount
    {
        [Key]
        public long id_onlinePaymentPreparedAccount { get; set; }

        [Required]
        [StringLength(50)]
        public string account { get; set; }

        public int id_rate { get; set; }

        public int id_a_year { get; set; }

        public int id_faculty { get; set; }

        public int id_speciality { get; set; }

        public int id_student { get; set; }

        public int id_groupStudent { get; set; }

        public int id_teacher { get; set; }

        public int id_abiturient { get; set; }

        [Required]
        [StringLength(100)]
        public string additional { get; set; }

        public float customSum { get; set; }
    }
}
