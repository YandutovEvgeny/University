//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class Students
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public Nullable<int> RostRum_Id { get; set; }
        public Nullable<int> Teacher_Id { get; set; }
    
        public virtual Rostra Rostra { get; set; }
        public virtual Teachers Teachers { get; set; }
    }
}
