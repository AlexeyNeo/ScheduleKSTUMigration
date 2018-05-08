namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class abit_2
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_student { get; set; }

        public int? Faculties { get; set; }

        public int? d_reg { get; set; }

        public int? m_reg { get; set; }

        public int? y_reg { get; set; }
    }
}
