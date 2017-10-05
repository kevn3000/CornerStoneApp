using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CornerStoneApp.Models;

namespace CornerStoneApp
{
    public static class Database
    {
       
        public static void Configure()
        {
            var config = new Configuration();
            config.Configure();
        }

        public static void OpenSession()
        {

        }


        public static void CloseSession()
        {

        }
    }
}