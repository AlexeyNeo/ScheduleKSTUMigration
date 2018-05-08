namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class V_Test_samoozenka
    {
        public int? id_student { get; set; }

        [StringLength(25)]
        public string p1 { get; set; }

        [StringLength(25)]
        public string p2 { get; set; }

        [StringLength(25)]
        public string p3 { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_test_type { get; set; }

        [StringLength(250)]
        public string test_type { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_test_category { get; set; }

        [StringLength(2)]
        public string Names { get; set; }

        [StringLength(50)]
        public string Descriptionn { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_test_vopros { get; set; }

        public string namess { get; set; }
    }
}
