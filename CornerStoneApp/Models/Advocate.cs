using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CornerStoneApp.Models
{
   
    public class Advocate: Person
    {
        String login { get; set; }
        String password { get; set; }
        List<Child> assignedChildren =new List<Child>();//List of all children assigned to advocate

        public Advocate(string firstName, string lastName, bool isMember,string login, string password) : base(firstName, lastName, isMember)
        {
        }
    }
}