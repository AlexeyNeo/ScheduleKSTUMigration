namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class f_AVN28_gr_potok_base
    {
        public int? id_teacher { get; set; }

        public int? id_a_year { get; set; }

        public int? id_sem { get; set; }

        public int? id_login { get; set; }

        public int? isSelect { get; set; }

        public int? id_discipline { get; set; }

        public int? id_examination { get; set; }

        public int? id_gr_potok { get; set; }

        [StringLength(264)]
        public string gr_potok { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_f_educ { get; set; }

        public double? prov_reyt { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int kredit { get; set; }
    }
}
