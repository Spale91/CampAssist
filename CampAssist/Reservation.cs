//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CampAssist
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reservation()
        {
            this.ReservationDates = new HashSet<ReservationDate>();
            this.ReservationGuests = new HashSet<ReservationGuest>();
        }
    
        public int ReservationID { get; set; }
        public Nullable<int> TypeID { get; set; }
        public Nullable<int> AccommodationUnitID { get; set; }
        public Nullable<double> Price { get; set; }
    
        public virtual AccommodationUnit AccommodationUnit { get; set; }
        public virtual Type Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservationDate> ReservationDates { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservationGuest> ReservationGuests { get; set; }
    }
}
