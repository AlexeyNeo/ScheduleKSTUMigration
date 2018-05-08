namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlaseSetrORT")]
    public partial class PlaseSetrORT
    {
        [Key]
        public short IDPlase { get; set; }

        [Required]
        [StringLength(25)]
        public string NamePlase { get; set; }

        [Required]
        [StringLength(25)]
        public string ColorSert { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [StringLength(70)]
        public string dop_place { get; set; }
    }
}
