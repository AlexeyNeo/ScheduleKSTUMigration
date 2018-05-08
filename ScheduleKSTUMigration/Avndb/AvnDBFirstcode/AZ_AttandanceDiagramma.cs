namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AZ_AttandanceDiagramma
    {
        public int? id_a_year { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_w_s { get; set; }

        [StringLength(50)]
        public string NameFaculty { get; set; }

        public int? id_teacher { get; set; }

        public int? EmployeeID { get; set; }
    }
}
