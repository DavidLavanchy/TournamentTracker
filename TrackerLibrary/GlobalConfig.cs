using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }

        public static void InitializeConnections(bool database, bool textfiles)
        {
            if (database)
            {
                // TODO - Create SQL Connection
            }

            if (textfiles)
            {
                // TODO - Create Text connection
            }
        }
    }
}
