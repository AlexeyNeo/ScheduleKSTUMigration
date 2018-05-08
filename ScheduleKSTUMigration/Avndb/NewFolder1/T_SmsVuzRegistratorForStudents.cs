namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_SmsVuzRegistratorForStudents
    {
        [Key]
        public long id_smsVuzRegistratorForStudent { get; set; }

        public long avn_id_smsRegistratorForUsers { get; set; }

        public int id_student { get; set; }

        [Required]
        [StringLength(20)]
        public string phoneNumber { get; set; }

        public int smsCount { get; set; }

        [Column(TypeName = "date")]
        public DateTime startDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime endDate { get; set; }

        public DateTime created { get; set; }
    }
}
