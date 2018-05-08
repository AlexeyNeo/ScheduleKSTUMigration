namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Citizenship")]
    public partial class Citizenship
    {
        [Key]
        public int IDCitizenship { get; set; }

        [Column("Citizenship")]
        [Required]
        [StringLength(25)]
        public string Citizenship1 { get; set; }

        public int id_country { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public virtual country country { get; set; }
    }
}
