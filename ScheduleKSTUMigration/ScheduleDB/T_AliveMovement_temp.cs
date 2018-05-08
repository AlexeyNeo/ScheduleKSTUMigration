namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_AliveMovement_temp
    {
        [Key]
        public int id_aliveMovement { get; set; }

        public int? id_protocols { get; set; }

        public int id_group { get; set; }

        public int id_student { get; set; }

        public int id_rate { get; set; }

        public int id_semester { get; set; }

        public int id_bk { get; set; }

        public int id_come { get; set; }

        [StringLength(40)]
        public string come_reg { get; set; }

        public DateTime? come_date { get; set; }

        [StringLength(70)]
        public string come_k { get; set; }

        public int? id_speciality { get; set; }

        public int id_leave { get; set; }

        [StringLength(40)]
        public string leave_reg { get; set; }

        public DateTime? leave_date { get; set; }

        [StringLength(70)]
        public string leave_k { get; set; }

        public int percent_privilege { get; set; }

        [StringLength(200)]
        public string privilege_coment { get; set; }

        public bool? priv_var { get; set; }

        [StringLength(30)]
        public string AVN_user { get; set; }

        [Required]
        [StringLength(128)]
        public string caller { get; set; }

        public int id_logAction { get; set; }

        public DateTime created { get; set; }

        [Required]
        [StringLength(100)]
        public string host { get; set; }
    }
}
