using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Demo_MQTT.MyMqttClient;

namespace Demo_MQTT
{
    class Program : MyMqttClient
    {
        static void Main(string[] args)
        {
            MyMqttClient newClient = new MyMqttClient();
            newClient.Init();
            Console.ReadKey();
        }
    }
}
