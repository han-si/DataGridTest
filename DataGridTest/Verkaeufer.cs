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
    
    public partial class Verkaeufer
    {
        public Verkaeufer()
        {
            this.Vertraege = new HashSet<Vertraege>();
        }
    
        public int verkaeuferID { get; set; }
        public string verkaeufername1 { get; set; }
        public string verkaeufername2 { get; set; }
        public string strasse { get; set; }
        public string plz { get; set; }
        public string ort { get; set; }
        public string land { get; set; }
        public string ansprechpartner { get; set; }
        public string tel1 { get; set; }
        public string tel2 { get; set; }
        public string email1 { get; set; }
        public string email2 { get; set; }
        public string web { get; set; }
        public string verkaeufernotiz { get; set; }
    
        public virtual ICollection<Vertraege> Vertraege { get; set; }
    }
}
