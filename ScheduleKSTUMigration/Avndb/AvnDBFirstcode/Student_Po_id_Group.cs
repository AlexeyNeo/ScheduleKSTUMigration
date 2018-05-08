namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student_Po_id_Group
    {
        [StringLength(56)]
        public string p20 { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_group { get; set; }

        public int? id_student { get; set; }

        [StringLength(50)]
        public string idid { get; set; }

        [StringLength(70)]
        public string s_fio { get; set; }

        public int? o_z { get; set; }
    }
}
