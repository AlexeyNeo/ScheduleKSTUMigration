namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_SmsActions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_smsAction { get; set; }

        [Required]
        [StringLength(100)]
        public string name { get; set; }

        [Required]
        [StringLength(200)]
        public string description { get; set; }

        [Required]
        [StringLength(500)]
        public string smsText { get; set; }
    }
}
