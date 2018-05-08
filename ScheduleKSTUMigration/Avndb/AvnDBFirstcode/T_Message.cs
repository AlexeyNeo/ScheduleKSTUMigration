namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Message
    {
        [Key]
        public int id_message { get; set; }

        public int id_w_s { get; set; }

        public int id_discipline { get; set; }

        public int? id_examination { get; set; }

        public string message { get; set; }

        public DateTime date { get; set; }

        public int id_HumanFrom { get; set; }

        public int id_humanTypeFrom { get; set; }

        [Column("____id_group")]
        public int? C____id_group { get; set; }

        public bool? isDeleted { get; set; }

        public byte? typeMsg { get; set; }

        public int id_avn_user { get; set; }

        public int? id_a_year { get; set; }
    }
}
