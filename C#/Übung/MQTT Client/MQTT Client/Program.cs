using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MQTT_Client
{
    class Program
    {
        private const string MQTTclientID = "Client1";
        private const string MQTTtcpServer = "localhost";
        private const int MQTTport = 1883;

        static void Main(string[] args)
        {
            var listener = new MqttListener();

            listener.Init(MQTTclientID, MQTTtcpServer, MQTTport);

            while (true){
                listener.Listener();
            }
            Console.ReadLine();
        }
    }
}
