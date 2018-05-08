namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rrnk_a2
    {
        public int? id_rrnk { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_kafedra { get; set; }

        [StringLength(300)]
        public string kafedra { get; set; }

        public int? id_year { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string year { get; set; }

        public int? id_teacher { get; set; }

        [StringLength(152)]
        public string teacher { get; set; }

        public int? id_semester { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(30)]
        public string semester { get; set; }

        public int? id_discipline { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(300)]
        public string discipline { get; set; }

        public int? id_examination { get; set; }

        [StringLength(50)]
        public string examination { get; set; }

        public int? id_group { get; set; }

        [StringLength(56)]
        public string group { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string faculty { get; set; }
    }
}
