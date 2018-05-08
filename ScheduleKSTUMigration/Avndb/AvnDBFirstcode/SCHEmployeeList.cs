namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SCHEmployeeList")]
    public partial class SCHEmployeeList
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_teacher { get; set; }

        [StringLength(152)]
        public string FIO { get; set; }

        [StringLength(70)]
        public string post { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_leave { get; set; }

        public int? id_structure { get; set; }

        public int? id_faculty { get; set; }

        public int? id_kafedra { get; set; }

        [StringLength(50)]
        public string sn_f1 { get; set; }

        [StringLength(209)]
        public string t_fio { get; set; }
    }
}
