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
    
    public partial class Geraetetypen
    {
        public Geraetetypen()
        {
            this.Geraete = new HashSet<Geraete>();
        }
    
        public int geraetetypID { get; set; }
        public string geraetetyp { get; set; }
        public string geraetetypbeschr { get; set; }
    
        public virtual ICollection<Geraete> Geraete { get; set; }
    }
}