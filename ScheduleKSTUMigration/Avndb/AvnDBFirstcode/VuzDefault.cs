namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class VuzDefault
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_vuz_defaults { get; set; }

        [Required]
        [StringLength(200)]
        public string n_avn_prog { get; set; }

        [Column(TypeName = "ntext")]
        [Required]
        public string descr { get; set; }

        [Required]
        [StringLength(20)]
        public string n_field { get; set; }

        public int id_field { get; set; }
    }
}
