//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScheduleKSTUMigration.Avndb
{
    using System;
    using System.Collections.Generic;
    
    public partial class SCHStudyType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SCHStudyType()
        {
            this.SCHSchedule = new HashSet<SCHSchedule>();
        }
    
        public int ID { get; set; }
        public string StudyTypeName { get; set; }
        public string StudyTypeName_full { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCHSchedule> SCHSchedule { get; set; }
    }
}
