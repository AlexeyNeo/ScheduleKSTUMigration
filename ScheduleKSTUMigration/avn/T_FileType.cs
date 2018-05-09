namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_FileType
    {
        [Key]
        public int id_fileType { get; set; }

        [StringLength(50)]
        public string filetypeName { get; set; }

        public byte? typeMsg { get; set; }

        public bool? isForStudent { get; set; }
    }
}
