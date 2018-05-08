namespace ScheduleKSTUMigration.ScheduleDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class educ_sh
    {
        [Key]
        public int id_educ_sh { get; set; }

        public int id_speciality { get; set; }

        public int id_a_year { get; set; }

        public int id_semester { get; set; }

        public int? id_component { get; set; }

        public int? id_kind { get; set; }

        public int? id_teacher { get; set; }

        public int id_kafedra { get; set; }

        public int id_discipline { get; set; }

        public int id_control { get; set; }

        public int id_examination { get; set; }

        public double p51 { get; set; }

        public double p52 { get; set; }

        public double p53 { get; set; }

        public double? srs { get; set; }

        public double? rzr { get; set; }

        public double? ind_z { get; set; }

        public double? seminar { get; set; }

        public int p54 { get; set; }

        [StringLength(5)]
        public string oper { get; set; }

        public DateTime? u_date { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public int? Krdt { get; set; }

        public int? descGroupNum { get; set; }

        public int? isSelect { get; set; }

        public int? colnedel { get; set; }

        public double? interactive { get; set; }

        public double? srsp { get; set; }

        [StringLength(50)]
        public string code_discipline { get; set; }

        public int? vid_discipline { get; set; }

        public double? koefZD { get; set; }

        public int? id_disciplineName { get; set; }

        public virtual a_year a_year { get; set; }

        public virtual com_sfe com_sfe { get; set; }

        public virtual component component { get; set; }

        public virtual control control { get; set; }

        public virtual discipline discipline { get; set; }

        public virtual examination examination { get; set; }

        public virtual kafedra kafedra { get; set; }

        public virtual kind kind { get; set; }

        public virtual semester semester { get; set; }

        public virtual teacher teacher { get; set; }
    }
}
