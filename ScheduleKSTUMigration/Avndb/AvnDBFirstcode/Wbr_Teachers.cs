namespace ScheduleKSTUMigration.Avndb.AvnDBFirstcode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Wbr_Teachers
    {
        [Key]
        public int Ident { get; set; }

        public int Room_Id { get; set; }

        public int Teacher_Id { get; set; }
    }
}
