namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class s_g_r
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_a_year { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string p32 { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_group { get; set; }

        [StringLength(56)]
        public string p20 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_rate { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string p22 { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_student { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(77)]
        public string s_fio { get; set; }
    }
}
