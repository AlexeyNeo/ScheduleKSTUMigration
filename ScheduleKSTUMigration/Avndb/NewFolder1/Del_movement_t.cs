namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Del_movement_t
    {
        [Key]
        public int id_protocols { get; set; }

        public int id_group { get; set; }

        public int id_student { get; set; }

        public int id_rate { get; set; }

        public int id_semester { get; set; }

        public int? id_bk { get; set; }

        [StringLength(20)]
        public string oper { get; set; }

        public DateTime? u_date { get; set; }

        public int id_come { get; set; }

        [StringLength(30)]
        public string come_reg { get; set; }

        public DateTime? come_date { get; set; }

        public int id_leave { get; set; }

        [StringLength(30)]
        public string leave_reg { get; set; }

        public DateTime? leave_date { get; set; }

        public bool? Check_ch { get; set; }

        public DateTime del_date { get; set; }

        [Required]
        [StringLength(50)]
        public string del_oper { get; set; }

        [StringLength(100)]
        public string descr { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }
    }
}
