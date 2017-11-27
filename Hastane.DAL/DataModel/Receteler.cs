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
    
    public partial class Receteler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Receteler()
        {
            this.ReceteDetay = new HashSet<ReceteDetay>();
        }
    
        public int ReceteID { get; set; }
        public System.DateTime Tarih { get; set; }
        public int KabulID { get; set; }
        public int KurumID { get; set; }
        public int PersonelID { get; set; }
        public int HastaID { get; set; }
        public bool Silindi { get; set; }
    
        public virtual HastaKabul HastaKabul { get; set; }
        public virtual Hastalar Hastalar { get; set; }
        public virtual Kurumlar Kurumlar { get; set; }
        public virtual Personeller Personeller { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceteDetay> ReceteDetay { get; set; }
    }
}