//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FilmlerKatmanli.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Oyuncular
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Oyuncular()
        {
            this.FilmOyunculars = new HashSet<FilmOyuncular>();
        }
    
        public int OyuncuID { get; set; }
        public string OyuncuAdi { get; set; }
        public string OyuncuSoyadi { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FilmOyuncular> FilmOyunculars { get; set; }
    }
}
