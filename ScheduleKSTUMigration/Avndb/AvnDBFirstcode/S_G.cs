namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_G
    {
        [Key]
        public int id_s_g { get; set; }

        public int? id_student { get; set; }

        [StringLength(70)]
        public string s_fio { get; set; }

        public int? id_group { get; set; }

        [StringLength(50)]
        public string p20 { get; set; }

        [StringLength(50)]
        public string idid { get; set; }

        [StringLength(50)]
        public string e_mail { get; set; }

        public int? id_bk { get; set; }

        public int? id_semester { get; set; }

        public int? id_protocols { get; set; }

        public int? id_start_semester { get; set; }

        public int? id_speciality { get; set; }
    }
}
