namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temp_log
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_database { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_table { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string table { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_field { get; set; }

        [Key]
        [Column(Order = 4)]
        public string name { get; set; }

        [StringLength(50)]
        public string detal { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(100)]
        public string value { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_user { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string userComp { get; set; }
    }
}
