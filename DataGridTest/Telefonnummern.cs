//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataGridTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class Telefonnummern
    {
        public Telefonnummern()
        {
            this.Simkarten = new HashSet<Simkarten>();
            this.Verbrauch = new HashSet<Verbrauch>();
        }
    
        public int telnrID { get; set; }
        public string telnr { get; set; }
        public int vertragID { get; set; }
        public Nullable<int> netzID { get; set; }
        public string telnrnotiz { get; set; }
    
        public virtual Netze Netze { get; set; }
        public virtual ICollection<Simkarten> Simkarten { get; set; }
        public virtual Vertraege Vertraege { get; set; }
        public virtual ICollection<Verbrauch> Verbrauch { get; set; }
    }
}
