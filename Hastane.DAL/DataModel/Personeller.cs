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
    
    public partial class Personeller
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Personeller()
        {
            this.HastaKabul = new HashSet<HastaKabul>();
            this.Randevular = new HashSet<Randevular>();
            this.Receteler = new HashSet<Receteler>();
            this.Teshisler = new HashSet<Teshisler>();
        }
    
        public int PersonelID { get; set; }
        public string PersonelKodu { get; set; }
        public string TCKimlikNo { get; set; }
        public int SicilNo { get; set; }
        public int UnvanID { get; set; }
        public Nullable<int> KlinikID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public string EvTel { get; set; }
        public string CepTel { get; set; }
        public System.DateTime DogumTarihi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public bool Siilindi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HastaKabul> HastaKabul { get; set; }
        public virtual Klinikler Klinikler { get; set; }
        public virtual Unvanlar Unvanlar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Randevular> Randevular { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Receteler> Receteler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Teshisler> Teshisler { get; set; }
    }
}
