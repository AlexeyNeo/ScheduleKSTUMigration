namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SCHWeekDay")]
    public partial class SCHWeekDay
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string WeekDayName { get; set; }

        [Required]
        [StringLength(3)]
        public string WeekDayNameShort { get; set; }

        [Required]
        [StringLength(20)]
        public string WeekDayNameKG { get; set; }

        [Required]
        [StringLength(3)]
        public string WeekDayNameShortKG { get; set; }
    }
}
