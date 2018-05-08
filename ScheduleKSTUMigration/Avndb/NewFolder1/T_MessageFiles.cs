namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_MessageFiles
    {
        [Key]
        public int id_messageFile { get; set; }

        public int? id_message { get; set; }

        [StringLength(255)]
        public string fileName { get; set; }

        public int? id_fileType { get; set; }

        public bool isDeleted { get; set; }
    }
}
