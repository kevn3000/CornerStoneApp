using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CornerStoneApp.Models
{
    public class Child: Person
    {
        string diagnosis { get; set; }

        List<Child> childList = new List<Child>();//List of Children to go on data base
        List<Diagnosis> diagnosisList = new List<Diagnosis>();//List of diagnosis of child

    }
}