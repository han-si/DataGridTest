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
    
    public partial class Simkarten
    {
        public Simkarten()
        {
            this.Simnutzung = new HashSet<Simnutzung>();
        }
    
        public int simkartenID { get; set; }
        public string simkartennr { get; set; }
        public string pin1 { get; set; }
        public string puk1 { get; set; }
        public string pin2 { get; set; }
        public string puk2 { get; set; }
        public Nullable<int> simgroesseID { get; set; }
        public int telnrID { get; set; }
        public string simkartennotiz { get; set; }
    
        public virtual Simgroessen Simgroessen { get; set; }
        public virtual Telefonnummern Telefonnummern { get; set; }
        public virtual ICollection<Simnutzung> Simnutzung { get; set; }
    }
}