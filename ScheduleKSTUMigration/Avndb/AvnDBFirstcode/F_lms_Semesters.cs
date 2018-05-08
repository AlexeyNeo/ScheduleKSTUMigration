namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class F_lms_Semesters
    {
        public int? id_teacher { get; set; }

        public int? id_a_year { get; set; }

        public int? id_sem { get; set; }

        public int? id_login { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string sem { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int isSelect { get; set; }

        public double? prov_reyt { get; set; }

        public int? ws_sort { get; set; }

        public int? id_w_s { get; set; }
    }
}