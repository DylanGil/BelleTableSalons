using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ppe1
{
    public static class ConnectSQL
    {
        public static string GiveWanConnection()
        {
            return "server=192.168.16.210;user id = root;password=aze!123; database=belletable_salons_dylang";
        }
        public static string GiveLocalConnection()
        {
            return "server = localhost; user id = root;database=cppe";
        }
        public static string GiveOnlineConnection() //notWorking
        {
            return "server=78.199.84.127;user id = root;password=aze!123; database=belletable_salons_dylang";
        }
    }

    


}
