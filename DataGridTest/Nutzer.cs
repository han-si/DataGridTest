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
    
    public partial class Nutzer
    {
        public Nutzer()
        {
            this.Simnutzung = new HashSet<Simnutzung>();
        }
    
        public int nutzerID { get; set; }
        public string vorname { get; set; }
        public string nachname { get; set; }
        public int abteilungID { get; set; }
        public string nutzernotiz { get; set; }
    
        public virtual Abteilungen Abteilungen { get; set; }
        public virtual ICollection<Simnutzung> Simnutzung { get; set; }
    }
}
