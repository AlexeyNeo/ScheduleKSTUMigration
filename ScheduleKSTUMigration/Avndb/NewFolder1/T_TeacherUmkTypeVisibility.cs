namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_TeacherUmkTypeVisibility
    {
        [Key]
        public long id_teacherUmkTypeVisibility { get; set; }

        public int id_typeUmk { get; set; }

        public int id_discipline { get; set; }

        public int id_avn_user { get; set; }

        public bool isVisible { get; set; }
    }
}
