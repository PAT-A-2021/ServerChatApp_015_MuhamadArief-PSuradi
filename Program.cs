using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFService_2Way_20190140015;
using System.ServiceModel;

namespace ServerChatApp_20190140015_Muhamad_Arief_P_Suradi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = null;
            try
            {
                host = new ServiceHost(typeof(ServiceCallback));
                host.Open();

                Console.WriteLine("Server nyala!");
                Console.ReadLine();

                host.Close();
            }
            catch (Exception ex)
            {
                host = null;
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }
    }
}
