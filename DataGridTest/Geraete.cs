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
    
    public partial class Geraete
    {
        public Geraete()
        {
            this.Simnutzung = new HashSet<Simnutzung>();
        }
    
        public int geraeteID { get; set; }
        public string geraetenr { get; set; }
        public string geraeteinventarnr { get; set; }
        public string geraeteimei { get; set; }
        public int geraetetypID { get; set; }
        public Nullable<int> geraeteherstID { get; set; }
        public Nullable<int> geraetemodellID { get; set; }
        public Nullable<int> simgroesseID { get; set; }
        public Nullable<int> betriebssysID { get; set; }
        public Nullable<System.DateTime> inbetriebnahme { get; set; }
        public string geraetenotiz { get; set; }
    
        public virtual Betriebssysteme Betriebssysteme { get; set; }
        public virtual Geraetehersteller Geraetehersteller { get; set; }
        public virtual Geraetemodelle Geraetemodelle { get; set; }
        public virtual Geraetetypen Geraetetypen { get; set; }
        public virtual Simgroessen Simgroessen { get; set; }
        public virtual ICollection<Simnutzung> Simnutzung { get; set; }
    }
}
