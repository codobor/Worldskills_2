using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    internal class database
    {
        static string connectionString = "server=localhost;user=root;database=hospital;port=3306;password=1234";

        public static string getConnection()
        {
            return connectionString;
        }
    }
}
