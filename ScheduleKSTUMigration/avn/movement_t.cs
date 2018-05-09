namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class movement_t
    {
        [Key]
        public int id_protocols { get; set; }

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

        [StringLength(20)]
        public string oper { get; set; }

        public DateTime? u_date { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public int percent_privilege { get; set; }

        [StringLength(200)]
        public string privilege_coment { get; set; }

        public bool? priv_var { get; set; }

        public bool isStudying { get; set; }

        [StringLength(100)]
        public string host { get; set; }

        public virtual com_sfe com_sfe { get; set; }

        public virtual come come { get; set; }

        public virtual group_t group_t { get; set; }

        public virtual leave leave { get; set; }

        public virtual rate rate { get; set; }

        public virtual semester semester { get; set; }

        public virtual Student Student { get; set; }
    }
}
