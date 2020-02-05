using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Zaya
{
    static class DataBaseConfiguration
    {
        private static ZayaDBDataContext context = null;

        private static string CONNECTION_STRING_NAME = "GestionQuizDB";
        private static string stringConnection;
        private static void InitContext()
        {
            stringConnection = ConfigurationManager.ConnectionStrings[CONNECTION_STRING_NAME].ConnectionString;
            stringConnection += ";password=123456"; 
            context = new ZayaDBDataContext(stringConnection);
        }


        public static ZayaDBDataContext Context
        {
            get
            {
                if (context == null)
                    InitContext();
                return context;
            }
        }


    }
}

