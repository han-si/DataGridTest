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
    
    public partial class Tarife
    {
        public Tarife()
        {
            this.Vertraege = new HashSet<Vertraege>();
        }
    
        public int tarifID { get; set; }
        public string tarifname { get; set; }
        public string tarifbeschr { get; set; }
    
        public virtual ICollection<Vertraege> Vertraege { get; set; }
    }
}