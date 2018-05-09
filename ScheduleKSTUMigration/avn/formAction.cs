namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("formAction")]
    public partial class formAction
    {
        [Key]
        public int id_form_action { get; set; }

        [StringLength(16)]
        public string ip { get; set; }

        [StringLength(20)]
        public string compName { get; set; }

        [StringLength(20)]
        public string inputLogin { get; set; }

        [StringLength(50)]
        public string progAVN { get; set; }

        public byte? id_action { get; set; }

        public DateTime? a_date { get; set; }

        public short? whoType { get; set; }
    }
}
