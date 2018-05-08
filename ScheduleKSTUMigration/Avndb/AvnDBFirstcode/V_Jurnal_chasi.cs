namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_Jurnal_chasi
    {
        public int? id_a_year { get; set; }

        public int? id_w_s { get; set; }

        public int? id_semester { get; set; }

        public int? id_discipline { get; set; }

        public int? Krdt { get; set; }

        public int? subgroup { get; set; }

        public int? id_teacher { get; set; }

        public int? id_group { get; set; }

        public int? id_examination { get; set; }

        public int? id_kafedra { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [Key]
        [Column(Order = 1)]
        public double lk { get; set; }

        [Key]
        [Column(Order = 2)]
        public double lb { get; set; }

        [Key]
        [Column(Order = 3)]
        public double pr { get; set; }

        [Key]
        [Column(Order = 4)]
        public double sum { get; set; }
    }
}
