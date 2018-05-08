namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("rashod")]
    public partial class rashod
    {
        [Key]
        public int id_rashod { get; set; }

        public int id_student { get; set; }

        public int? id_teacher { get; set; }

        public int id_faculty { get; set; }

        [StringLength(100)]
        public string osnovanie { get; set; }

        public int? id_usluga_rashod { get; set; }

        public double summa { get; set; }

        public DateTime date_r { get; set; }

        public int? ord_f { get; set; }

        public int id_v_opl { get; set; }

        [StringLength(100)]
        public string dopol { get; set; }

        [StringLength(20)]
        public string oper { get; set; }

        public DateTime? u_date { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }
    }
}
