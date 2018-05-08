namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InfoForRating")]
    public partial class InfoForRating
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string p32 { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(80)]
        public string Semester { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_semester { get; set; }

        [Key]
        [Column("p23-2", Order = 3)]
        [StringLength(100)]
        public string p23_2 { get; set; }

        [Key]
        [Column("p23-1", Order = 4)]
        [StringLength(50)]
        public string p23_1 { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_a_year { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(10)]
        public string v1 { get; set; }
    }
}
