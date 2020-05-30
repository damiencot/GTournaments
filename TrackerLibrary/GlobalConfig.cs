using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnections(DataBaseType db)
        {
            if(db == DataBaseType.Sql)
            {
                // TODO - Create the SQL Connection
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if(db == DataBaseType.TextFile)
            {
                // TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                Connection = text;

            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

    }
}
