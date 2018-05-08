namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class f_AVN28_exam_base
    {
        public int? id_teacher { get; set; }

        public int? id_a_year { get; set; }

        public int? id_sem { get; set; }

        public int? id_login { get; set; }

        public int? isSelect { get; set; }

        public int? id_discipline { get; set; }

        public int? id_examination { get; set; }

        public double? prov_reyt { get; set; }

        public int? gr_potok { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kredit { get; set; }
    }
}
