using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using MQTTnet.Server;

namespace Demo_MQTT
{
    class MyMqttClient
    {
        private IMqttFactory factory = new MqttFactory();
        private IMqttClient mqttClient;
        private DateTime date1 = DateTime.Now;

        public async void Init()
        {
            mqttClient = factory.CreateMqttClient();

            var response = new MqttApplicationMessageBuilder()
                .WithTopic("ug/temp")
                .WithPayload("Hello World")
                .WithExactlyOnceQoS()
                .WithRetainFlag()
                .Build();

            var options = new MqttClientOptionsBuilder()
                .WithClientId("Client1")
                .WithTcpServer("localhost")
                .WithCleanSession()
                .Build();

            mqttClient.UseApplicationMessageReceivedHandler(async e =>
            {
                mqttClient = factory.CreateMqttClient();

                //if (TOPICS)

                Console.Write(date1.ToString());
                Console.Write($" Topic={e.ApplicationMessage.Topic};");
                Console.Write($" Message={Encoding.UTF8.GetString(e.ApplicationMessage.Payload)};");
                Console.Write($" QoS={e.ApplicationMessage.QualityOfServiceLevel};");
                Console.WriteLine();

                await mqttClient.PublishAsync(response, CancellationToken.None); // Since 3.0.5 with CancellationToken
            });

            mqttClient.UseConnectedHandler(async e =>
            {
                Console.WriteLine("### CONNECTED WITH SERVER ###");

                // Subscribe to a topic
                await mqttClient.SubscribeAsync(new MqttTopicFilterBuilder().WithTopic("daheim/og/temp").Build());
                await mqttClient.SubscribeAsync(new MqttTopicFilterBuilder().WithTopic("daheim/eg/temp").Build());

                Console.WriteLine("### SUBSCRIBED ###");
            });

            await mqttClient.ConnectAsync(options, CancellationToken.None); // Since 3.0.5 with CancellationToken

        }

        public async Task<bool> SendMessage(string payload, string topic)
        {
            var message = new MqttApplicationMessageBuilder()
                .WithTopic(topic)
                .WithPayload(payload)
                .Build();

            if (!mqttClient.IsConnected)
            {
                return false;
            }

            await mqttClient.PublishAsync(message, CancellationToken.None); // Since 3.0.5 with CancellationToken
            return true;
        }
    }
}
