namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class mark_mag_arch
    {
        [Key]
        public int id_mark_mag { get; set; }

        public int id_mark_mag_del { get; set; }

        public int id_group { get; set; }

        public int id_student { get; set; }

        public int id_examination { get; set; }

        public double? m1 { get; set; }

        public double? m2 { get; set; }

        public double? m3 { get; set; }

        public double? m4 { get; set; }

        public double? dop { get; set; }

        public double? dop2 { get; set; }

        public double? ball { get; set; }

        public int id_estimation { get; set; }

        public int id_discipline { get; set; }

        public int id_semester { get; set; }

        public int id_teacher { get; set; }

        [Required]
        [StringLength(50)]
        public string p35 { get; set; }

        public DateTime p36 { get; set; }

        public int id_f_est { get; set; }

        [StringLength(30)]
        public string oper { get; set; }

        public DateTime? u_date { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        [StringLength(50)]
        public string primech { get; set; }

        public double? m5 { get; set; }

        public double? m6 { get; set; }

        public double? m7 { get; set; }

        public double? m8 { get; set; }

        public double? m9 { get; set; }

        public double? m10 { get; set; }

        public double? m11 { get; set; }

        public double? m12 { get; set; }

        public int? k_count { get; set; }

        public int? id_estimation_other { get; set; }

        public bool? dopusk_izm { get; set; }

        public bool isStaticDiscipline { get; set; }

        public int kredits { get; set; }

        public int? id_ebe_var { get; set; }

        public int? id_faculty { get; set; }

        public int? id_a_year { get; set; }
    }
}
