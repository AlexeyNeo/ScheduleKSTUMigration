namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class temp_log_upd
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
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long id_tableRow { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string oldValue { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string newValue { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_user { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime updated { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(100)]
        public string userComp { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(200)]
        public string AVN_login { get; set; }
    }
}
