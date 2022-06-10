using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using MQTTnet.Server;

namespace MQTT_Client
{
    internal class MqttListener
    {

        private IMqttFactory factory = new MqttFactory();
        private IMqttClient mqttClient;
        private const string MQTTtopic = "invoice/position";

        public async void Listener()
        {


            mqttClient.UseConnectedHandler(async e =>
            {
                Console.WriteLine("### CONNECTED WITH SERVER ###");

                // Subscribe to a topic
                await mqttClient.SubscribeAsync(new MqttTopicFilterBuilder().WithTopic(MQTTtopic).Build());

                Console.WriteLine("### SUBSCRIBED ###");

            });

            mqttClient.UseApplicationMessageReceivedHandler(e =>
            {
                Console.WriteLine("### RECEIVED APPLICATION MESSAGE ###");
                Console.WriteLine($"+ Topic = {e.ApplicationMessage.Topic}");
                Console.WriteLine($"+ Payload = {Encoding.UTF8.GetString(e.ApplicationMessage.Payload)}");
                Console.WriteLine($"+ QoS = {e.ApplicationMessage.QualityOfServiceLevel}");
                Console.WriteLine($"+ Retain = {e.ApplicationMessage.Retain}");
                Console.WriteLine();

            });

        }


        public async void Init(string clientID, string tcpServer, int port)
        {
            mqttClient = factory.CreateMqttClient();
            var options = new MqttClientOptionsBuilder()
                .WithClientId(clientID)
                .WithTcpServer(tcpServer, port)
                .WithCleanSession()
                .Build();

            try
            {
                await mqttClient.ConnectAsync(options, CancellationToken.None); // Since 3.0.5 with CancellationToken
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
