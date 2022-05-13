using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Demo_MQTT.MyMqttClient;

namespace Demo_MQTT
{
    class  Program : MyMqttClient
    {
        static void Main(string[] args)
        {
            var mqttClient = new MyMqttClient();
            mqttClient.Init();
            var sendtask = mqttClient.SendMessage("Inhalt", "topic/test");
            sendtask.Wait();
        }
    }
}
