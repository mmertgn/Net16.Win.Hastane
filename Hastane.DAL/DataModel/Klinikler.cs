//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hastane.DAL.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Klinikler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Klinikler()
        {
            this.HastaKabul = new HashSet<HastaKabul>();
            this.Hizmetler = new HashSet<Hizmetler>();
            this.Personeller = new HashSet<Personeller>();
        }
    
        public int KlinikID { get; set; }
        public string KlinikAd { get; set; }
        public string Aciklama { get; set; }
        public bool Silindi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaKabul> HastaKabul { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hizmetler> Hizmetler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Personeller> Personeller { get; set; }
    }
}
