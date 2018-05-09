namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_HistoryEmailToStudents
    {
        [Key]
        public int id_historyEmailToStudent { get; set; }

        public int id_avn_user_sender { get; set; }

        public int id_student { get; set; }

        [Required]
        [StringLength(100)]
        public string student_email { get; set; }

        public DateTime date { get; set; }

        [Required]
        public string message { get; set; }

        public bool isSuccess { get; set; }
    }
}
