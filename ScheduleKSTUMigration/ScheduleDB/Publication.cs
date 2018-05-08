namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Publication")]
    public partial class Publication
    {
        [Key]
        public int id_publication { get; set; }

        public int id_publicationType { get; set; }

        [StringLength(200)]
        public string theme { get; set; }

        public DateTime? PublicationDate { get; set; }

        public int id_teacher { get; set; }

        public int? Pages { get; set; }

        [StringLength(250)]
        public string Primech { get; set; }
    }
}
