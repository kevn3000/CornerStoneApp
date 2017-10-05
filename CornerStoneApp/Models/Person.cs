using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CornerStoneApp.Models
{
    public class Person
    {
        string firstName{get; set;}
        string lastName { get; set; }
        Membership membership = new Membership();//membership.isActive determines if membership is active
    }
}