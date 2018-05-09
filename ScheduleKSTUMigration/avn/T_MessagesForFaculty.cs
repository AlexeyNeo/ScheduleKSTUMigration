namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_MessagesForFaculty
    {
        [Key]
        public long id_messageForFaculty { get; set; }

        public int id_faculty { get; set; }

        public int id_human { get; set; }

        public int id_humanType { get; set; }

        [Required]
        public string message { get; set; }

        [Required]
        [StringLength(255)]
        public string fileName { get; set; }

        public int id_fileType { get; set; }

        public DateTime date { get; set; }

        public bool isRead { get; set; }

        public bool isDeleted { get; set; }
    }
}
