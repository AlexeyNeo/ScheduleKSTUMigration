namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class teacher_info
    {
        [Key]
        public int id_teacher_info { get; set; }

        public int id_teacher { get; set; }

        public int? id_uch_stepen { get; set; }

        public int? id_uch_zvanie { get; set; }

        public DateTime? D_b { get; set; }

        [StringLength(15)]
        public string Phon_w { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        [StringLength(15)]
        public string phone_mobile { get; set; }

        public DateTime? D_z { get; set; }

        public int? id_nationality { get; set; }

        public int? id_citizenship { get; set; }

        public int? id_pol { get; set; }

        [StringLength(50)]
        public string nauch_r { get; set; }

        public int? id_rang { get; set; }

        public int? id_soc_pr { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [StringLength(30)]
        public string eMail { get; set; }

        [StringLength(50)]
        public string first_p26 { get; set; }

        [StringLength(50)]
        public string num_date_f_p26 { get; set; }

        public virtual Nationality Nationality { get; set; }

        public virtual pol pol { get; set; }

        public virtual Rang Rang { get; set; }

        public virtual Soc_pr Soc_pr { get; set; }

        public virtual teacher teacher { get; set; }

        public virtual uch_step uch_step { get; set; }

        public virtual uch_zvanie uch_zvanie { get; set; }
    }
}
