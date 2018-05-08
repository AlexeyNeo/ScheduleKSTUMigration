namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_EmisHumanTemp
    {
        [Key]
        public int id_emisHumanTemp { get; set; }

        public int id_human { get; set; }

        public byte id_humanType { get; set; }

        public short status { get; set; }

        public byte type { get; set; }

        [Required]
        [StringLength(200)]
        public string exception { get; set; }
    }
}
