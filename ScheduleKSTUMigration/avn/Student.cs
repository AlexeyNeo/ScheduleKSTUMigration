namespace ScheduleKSTUMigration.avn
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            movement_t = new HashSet<movement_t>();
            InfoOnEdIns = new HashSet<InfoOnEdIns>();
        }

        [Key]
        public int id_student { get; set; }

        public int? nenujen { get; set; }

        [StringLength(15)]
        public string idid { get; set; }

        [StringLength(25)]
        public string first_p1 { get; set; }

        [StringLength(50)]
        public string num_date_f_p1 { get; set; }

        [Required]
        [StringLength(25)]
        public string p1 { get; set; }

        [Required]
        [StringLength(25)]
        public string p2 { get; set; }

        [StringLength(50)]
        public string place_work { get; set; }

        [Required]
        [StringLength(25)]
        public string p3 { get; set; }

        public DateTime? BirthDate { get; set; }

        public bool Male { get; set; }

        public bool? Lonely { get; set; }

        public bool? Orphan { get; set; }

        public bool? Invalid12Group { get; set; }

        public int? id_republicBirth { get; set; }

        public int RegionBirth { get; set; }

        public int DistrictBirth { get; set; }

        public int CityBirth { get; set; }

        public int VillageBirth { get; set; }

        [StringLength(400)]
        public string Streetbirth { get; set; }

        public int? id_republicHome { get; set; }

        public int RegionHomeAddress { get; set; }

        public int DistrictHomeAddress { get; set; }

        public int CityHomeAddress { get; set; }

        public int VillageHomeAddress { get; set; }

        [StringLength(400)]
        public string StreetHomeAddress { get; set; }

        [StringLength(400)]
        public string adrhome { get; set; }

        [StringLength(16)]
        public string TelephoneHomeAddress { get; set; }

        public int? id_republicNow { get; set; }

        public int RegionNow { get; set; }

        public int DistrictNow { get; set; }

        public int CityNow { get; set; }

        public int? VillageNow { get; set; }

        [StringLength(400)]
        public string StreetNow { get; set; }

        [StringLength(400)]
        public string adrnow { get; set; }

        [StringLength(16)]
        public string TelephoneNow { get; set; }

        [StringLength(25)]
        public string SerialPas { get; set; }

        [StringLength(25)]
        public string NumberPas { get; set; }

        public DateTime? DateGivenPas { get; set; }

        public int? GivenPas { get; set; }

        public int Nationality { get; set; }

        public int? first_Citizenship { get; set; }

        [StringLength(25)]
        public string num_date_f_Citizenship { get; set; }

        public bool? ItnGyrg { get; set; }

        public int Citizenship { get; set; }

        public int? id_a_year { get; set; }

        public int? id_ws { get; set; }

        [StringLength(10)]
        public string DateRegistr { get; set; }

        public int? FacultiesReg { get; set; }

        public bool? Dipend { get; set; }

        [StringLength(50)]
        public string e_mail { get; set; }

        [StringLength(50)]
        public string lang { get; set; }

        [StringLength(50)]
        public string hobby { get; set; }

        [StringLength(50)]
        public string religion { get; set; }

        [StringLength(100)]
        public string visitKG { get; set; }

        [StringLength(50)]
        public string aids { get; set; }

        [StringLength(20)]
        public string AVN_user { get; set; }

        public DateTime? AVN_update { get; set; }

        public int? temp { get; set; }

        [StringLength(15)]
        public string ZACH { get; set; }

        [StringLength(30)]
        public string inn { get; set; }

        [StringLength(50)]
        public string login { get; set; }

        [StringLength(32)]
        public string password { get; set; }

        public bool needChangePsw { get; set; }

        public DateTime startDateForChangePsw { get; set; }

        public byte? kol_p { get; set; }

        public DateTime? endDateViza { get; set; }

        public bool? needHome { get; set; }

        [StringLength(100)]
        public string host { get; set; }

        [StringLength(20)]
        public string smsAccountFromAbit { get; set; }

        [StringLength(32)]
        public string Attribute { get; set; }

        [StringLength(2)]
        public string op { get; set; }

        public byte? FlagForMobile { get; set; }

        [StringLength(50)]
        public string ist { get; set; }

        public virtual MilitaryInfo MilitaryInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<movement_t> movement_t { get; set; }

        public virtual ParentsInfo ParentsInfo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InfoOnEdIns> InfoOnEdIns { get; set; }
    }
}
