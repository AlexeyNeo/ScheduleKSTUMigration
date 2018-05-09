namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Exceptions
    {
        [Key]
        public long id_exception { get; set; }

        public int ERROR_NUMBER { get; set; }

        public int ERROR_SEVERITY { get; set; }

        public int ERROR_STATE { get; set; }

        public int ERROR_LINE { get; set; }

        [Required]
        [StringLength(300)]
        public string ERROR_PROCEDURE { get; set; }

        [Required]
        public string ERROR_MESSAGE { get; set; }

        public string additionalInfo { get; set; }

        public DateTime date { get; set; }
    }
}
