using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.InteropServices;
using System.Net.Http;

namespace NanopoolGUI
{
    class EthWorker
    {
        private static string id, hashrate, lastshare, avg1, avg3, avg6, avg12, avg24;
    }
    class GetThreadEth
    {
        private static string Balance, UnconfirmedBalance, Hashrate, AvgHashrateH6;
        private static void GetGeneralInfo(string account)
        {
            var url = "https://api.nanopool.org/v1/eth/user/" + account;
            string response;
            using (var client = new HttpClient())
            {
                response = 
            }
        }
    }
}
