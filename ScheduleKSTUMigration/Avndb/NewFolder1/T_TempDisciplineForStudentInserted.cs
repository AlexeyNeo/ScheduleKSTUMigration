namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_TempDisciplineForStudentInserted
    {
        public long id { get; set; }

        public int id_disciplineForStudent { get; set; }
    }
}
