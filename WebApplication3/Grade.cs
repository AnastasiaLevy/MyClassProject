//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Grade
    {
        public int Id { get; set; }
        public Nullable<int> Value { get; set; }
        public int PersonId { get; set; }
        public int ActivityId { get; set; }
    
        public virtual Activity Activity { get; set; }
        public virtual Person Person { get; set; }
    }
}
