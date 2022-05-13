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
using MyERP.Model;

namespace MyERP.MQTT
{
class Client
    {
        private IMqttFactory factory = new MqttFactory();
        private IMqttClient mqttClient;

        public async void Init(string clientID, string tcpServer, int port)
        {
            mqttClient = factory.CreateMqttClient();
            var options = new MqttClientOptionsBuilder()
                .WithClientId(clientID)
                .WithTcpServer(tcpServer,port)
                .WithCleanSession()
                .Build();

            await mqttClient.ConnectAsync(options, CancellationToken.None); // Since 3.0.5 with CancellationToken

        }

        public async Task<bool> SendInvoicePosition(Position Position)
        {
            if (mqttClient.IsConnected)
            {
                var Message = new MqttApplicationMessageBuilder()
                    .WithTopic("invoice/position")
                    .WithPayload($"ID: {Position.Id}; ItemNr: {Position.ItemNr} Price: {Position.Price} Qty: {Position.Qty}")
                    .WithExactlyOnceQoS()
                    .WithRetainFlag()
                    .Build();

                await mqttClient.PublishAsync(Message, CancellationToken.None); // Since 3.0.5 with CancellationToken
                return true;
            }
            return false;
        }

        public async Task<bool> SendAllInvoicePosition(Invoice Invoice)
        {
            if (mqttClient.IsConnected)
            {
                var Message = new MqttApplicationMessageBuilder()
                    .WithTopic("invoice/rechnung")
                    .WithPayload($"ID: {Invoice.Id} Date: {Invoice.InvoiceDate} Amount: {Invoice.Amount} Name: {Invoice.CustomerName} Adress: {Invoice.CustomerAddress}")
                    .WithExactlyOnceQoS()
                    .WithRetainFlag()
                    .Build();

                await mqttClient.PublishAsync(Message, CancellationToken.None); // Since 3.0.5 with CancellationToken
                return true;
            }
            return false;
        }

        public async Task<bool> SendInvoice(Invoice Invoice)
        {
            if (mqttClient.IsConnected)
            {
                foreach (var Position in Invoice.Positions)
                {
                    await SendInvoicePosition(Position);
                }
                return true;
            }
            return false;
        }
    }
}
