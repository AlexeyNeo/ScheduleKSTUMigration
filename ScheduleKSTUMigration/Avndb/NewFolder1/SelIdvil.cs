namespace ScheduleKSTUMigration.Avndb.NewFolder1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SelIdvil")]
    public partial class SelIdvil
    {
        [Key]
        [Column(Order = 0)]
        public int IDVillage { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDDistrict { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string NameVillage { get; set; }

        public short? IDAttribute { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(25)]
        public string Expr1 { get; set; }
    }
}
