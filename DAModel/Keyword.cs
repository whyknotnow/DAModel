//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Keyword
    {
        public Keyword()
        {
            this.MailGrubu_Keyword = new HashSet<MailGrubu_Keyword>();
        }
    
        public int Id { get; set; }
        public string Keyword1 { get; set; }
        public int MailId { get; set; }
    
        public virtual AtilacakMail AtilacakMail { get; set; }
        public virtual ICollection<MailGrubu_Keyword> MailGrubu_Keyword { get; set; }
    }
}
