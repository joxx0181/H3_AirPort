//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace H3_AirPort
{
    using System;
    using System.Collections.Generic;
    
    public partial class Airline
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Airline()
        {
            this.Operater = new HashSet<Operater>();
        }
    
        public int AirlineId { get; set; }
        public string AirlineName { get; set; }
        public Nullable<int> FlightNum { get; set; }
    
        public virtual Flight Flight { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operater> Operater { get; set; }
    }
}
