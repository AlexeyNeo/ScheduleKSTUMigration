namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_SmsAccountRegistartor
    {
        [Key]
        public long id_smsAccountRegistartor { get; set; }

        public int id_avn_user_created { get; set; }

        [Required]
        [StringLength(50)]
        public string account { get; set; }
    }
}
