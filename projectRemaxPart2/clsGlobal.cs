using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace projectRemaxPart2
{
    class clsGlobal
    {
        public static DataSet mySet;
        public static SqlConnection myConn;
        public static SqlDataAdapter adpEmployee, adpClient, adpProperty;
    }
}
