namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nagrada")]
    public partial class nagrada
    {
        [Key]
        public int id_nagrada { get; set; }

        [Column("nagrada")]
        [StringLength(100)]
        public string nagrada1 { get; set; }

        public DateTime? date_get { get; set; }

        [StringLength(30)]
        public string By_who { get; set; }

        public int? id_teacher { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public virtual teacher teacher { get; set; }
    }
}
