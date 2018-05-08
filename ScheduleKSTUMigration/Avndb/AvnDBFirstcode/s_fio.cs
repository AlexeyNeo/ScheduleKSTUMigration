namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class s_fio
    {
        [Key]
        [Column(Order = 0)]
        public int id_student { get; set; }

        [Key]
        [Column("s_fio", Order = 1)]
        [StringLength(77)]
        public string s_fio1 { get; set; }

        [StringLength(15)]
        public string idid { get; set; }

        [StringLength(30)]
        public string s_s_fio { get; set; }

        [StringLength(50)]
        public string e_mail { get; set; }
    }
}
