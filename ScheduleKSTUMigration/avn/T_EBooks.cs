namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_EBooks
    {
        [Key]
        [Column(Order = 0)]
        public long id_eBook { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_human { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_humanType { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(200)]
        public string name { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string author { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(500)]
        public string description { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int totalPages { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(255)]
        public string fileName { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_bookCategory { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime created { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool isDeleted { get; set; }
    }
}
