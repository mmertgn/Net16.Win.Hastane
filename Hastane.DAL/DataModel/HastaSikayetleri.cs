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
    
    public partial class HastaSikayetleri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HastaSikayetleri()
        {
            this.HastaKabul = new HashSet<HastaKabul>();
        }
    
        public int SikayetID { get; set; }
        public int HastaID { get; set; }
        public int KabulID { get; set; }
        public System.DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaKabul> HastaKabul { get; set; }
        public virtual HastaKabul HastaKabul1 { get; set; }
        public virtual Hastalar Hastalar { get; set; }
    }
}
