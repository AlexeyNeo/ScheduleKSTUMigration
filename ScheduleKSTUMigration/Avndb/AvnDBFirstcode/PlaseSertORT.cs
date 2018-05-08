namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlaseSertORT")]
    public partial class PlaseSertORT
    {
        [Key]
        [Column(Order = 0)]
        public short IDPlase { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string NamePlase { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string ColorSert { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [StringLength(70)]
        public string dop_place { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(53)]
        public string ColorAndPlace { get; set; }
    }
}
