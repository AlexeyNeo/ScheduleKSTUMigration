namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class educ_form
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_educ_form { get; set; }

        [Column("educ_form")]
        [Required]
        [StringLength(20)]
        public string educ_form1 { get; set; }
    }
}
