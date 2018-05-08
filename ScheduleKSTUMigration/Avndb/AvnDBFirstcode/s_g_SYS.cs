namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class s_g_SYS
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_student { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(77)]
        public string s_fio { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_group { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        [StringLength(15)]
        public string idid { get; set; }

        [StringLength(50)]
        public string e_mail { get; set; }

        public int? id_bk { get; set; }

        public int? id_semester { get; set; }

        public int? id_protocols { get; set; }

        public int? id_start_semester { get; set; }
    }
}
