using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CornerStoneApp.Models
{
    public class Person
    {
        public string firstName{get; set;}
        public string lastName { get; set; }
        public Membership membership = new Membership();//membership.isActive determines if membership is active
       public Person(string firstName,string lastName, Boolean isMember)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.membership.isActive = isMember;
        }
    }
}