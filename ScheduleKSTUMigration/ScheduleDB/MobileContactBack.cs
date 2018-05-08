namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobileContactBack")]
    public partial class MobileContactBack
    {
        public int ID { get; set; }

        public int MobileProblemID { get; set; }

        public int StudentID { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string Phone { get; set; }

        public string ContentText { get; set; }

        public int CreateUserID { get; set; }

        public DateTime RecordTimeStamp { get; set; }

        public virtual MobileProblem MobileProblem { get; set; }
    }
}
