namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AbiturientPhoto")]
    public partial class AbiturientPhoto
    {
        [Key]
        public int id_photo { get; set; }

        [Column(TypeName = "image")]
        public byte[] photo { get; set; }

        public int? id_student { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }
    }
}
