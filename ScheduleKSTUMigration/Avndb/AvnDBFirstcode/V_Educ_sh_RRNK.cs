namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_Educ_sh_RRNK
    {
        public int? id_educ_sh { get; set; }

        public int? id_group { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_type_chasov { get; set; }

        [StringLength(50)]
        public string n_type_chasov { get; set; }

        public int? id_teacher { get; set; }

        [StringLength(152)]
        public string t_fio { get; set; }

        [Key]
        [Column(Order = 1)]
        public double summ { get; set; }

        public byte? plan_fakt { get; set; }
    }
}
