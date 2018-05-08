namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("www")]
    public partial class www
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(255)]
        public string fileName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_discipline { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_human { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_typeUmk { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_books { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime created { get; set; }

        [Key]
        [Column(Order = 6)]
        public bool isHTMLBook { get; set; }
    }
}
