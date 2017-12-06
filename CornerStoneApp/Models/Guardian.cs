using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CornerStoneApp.Models
{
    public class Guardian:Person
    {
        
        List<Guardian> guardianList = new List<Guardian>();//List of Guardians to go on data base
        List<Child> childList = new List<Child>();//List of children belonging to Guardian

        public Guardian(string firstName, string lastName, bool isMember) : base(firstName, lastName, isMember)
        {
        }
    }
}