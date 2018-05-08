namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class t_rrnkdop_a
    {
        public int? id_a_year { get; set; }

        public int? id_kafedra { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_rrnk_dop { get; set; }

        public int? id_teacher { get; set; }

        [StringLength(100)]
        public string forWhat { get; set; }

        public double? hour { get; set; }

        public byte? plan_fakt { get; set; }

        public double? plann { get; set; }

        public double? fakt { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int count_pf { get; set; }

        public int? id_kassa { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_type_chasov_p_k { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_type_chasov_p_ch { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_type_chasov_f_k { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_type_chasov_f_ch { get; set; }
    }
}
