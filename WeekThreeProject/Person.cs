//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WeekThreeProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public Person()
        {
            this.Pictures = new HashSet<Picture>();
            this.Grades = new HashSet<Grades>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int PictureID { get; set; }
        public int LabId { get; set; }
        public Nullable<int> ClassID { get; set; }
    
        public virtual ICollection<Picture> Pictures { get; set; }
        public virtual Lab Lab { get; set; }
        public virtual ICollection<Grades> Grades { get; set; }
    }
}