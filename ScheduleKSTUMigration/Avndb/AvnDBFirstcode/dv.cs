namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dv")]
    public partial class dv
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_dv { get; set; }

        [Column("dv")]
        [Required]
        [StringLength(10)]
        public string dv1 { get; set; }

        [Required]
        [StringLength(50)]
        public string opl { get; set; }
    }
}
