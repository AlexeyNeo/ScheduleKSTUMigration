namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RRNKForIndividualPermiss")]
    public partial class RRNKForIndividualPermiss
    {
        public int? id_a_year { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string p32 { get; set; }

        public int? id_semester { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string p43 { get; set; }

        public int? id_group { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        public int? id_teacher { get; set; }

        [StringLength(152)]
        public string t_fio { get; set; }

        public int? id_discipline { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(300)]
        public string p34 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }
    }
}
