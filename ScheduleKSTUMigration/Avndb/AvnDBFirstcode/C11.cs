namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("11")]
    public partial class C11
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_faculty { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_country { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string s_p14_7 { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_Citizenship { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(25)]
        public string Citizenship { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_Nationality { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Nationality { get; set; }

        public int? kol_st { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool Male { get; set; }
    }
}
