namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class educ_sh_kpv
    {
        [Key]
        public int id_educ_sh_kpv { get; set; }

        public int id_speciality { get; set; }

        public int id_a_year { get; set; }

        public int id_semester { get; set; }

        public int? id_component { get; set; }

        public int? id_kind { get; set; }

        public int? id_teacher { get; set; }

        public int id_kafedra { get; set; }

        public int id_discipline { get; set; }

        public int? id_disciplineName { get; set; }

        public int id_control { get; set; }

        public int id_examination { get; set; }

        public int p51 { get; set; }

        public int p52 { get; set; }

        public int p53 { get; set; }

        public int? srs { get; set; }

        public int? rzr { get; set; }

        public int? ind_z { get; set; }

        public int? seminar { get; set; }

        public int p54 { get; set; }

        [StringLength(5)]
        public string oper { get; set; }

        public DateTime? u_date { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public int Krdt { get; set; }
    }
}
