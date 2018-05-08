namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temp_ALL
    {
        public int? id_group { get; set; }

        public int? id_a_year { get; set; }

        public int? id_rate { get; set; }

        public int? id_semester { get; set; }

        public int? id_discipline { get; set; }

        public int? id_examination { get; set; }

        public int? id_student { get; set; }

        public int? Krdt { get; set; }

        public int? id_estimation { get; set; }

        public bool? isStaticDiscipline { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int up { get; set; }

        public int? dfs { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sel { get; set; }

        [StringLength(300)]
        public string p34 { get; set; }
    }
}
