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
using MyERP.Model;
using Newtonsoft.Json;

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

            try
            {
                await mqttClient.ConnectAsync(options, CancellationToken.None); // Since 3.0.5 with CancellationToken
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public async Task<string> SendMqtt(string Payload, string Topic)
        {
            var Message = new MqttApplicationMessageBuilder()
                    .WithTopic(Topic)
                    .WithPayload(Payload)
                    .WithExactlyOnceQoS()
                    .WithRetainFlag()
                    .Build();

            try
            {
                await mqttClient.PublishAsync(Message, CancellationToken.None); // Since 3.0.5 with CancellationToken
            }
            catch (Exception e)
            {
                MessageBoxResult resultfaild = MessageBox.Show(e.ToString());
                return e.ToString();
            }

            return "";
        }
        

        public async Task<bool> SendInvoice(Invoice Invoices)
        {
            if (mqttClient.IsConnected)
            {
                foreach (var Position in Invoices.Positions)
                {
                    string topic = $"invoice/position";
                    string payload = $"ID: {Position.Id}; ItemNr: {Position.ItemNr} Price: {Position.Price} Qty: {Position.Qty}";
                    await SendMqtt( payload, topic);
                }
                MessageBoxResult resultsend = MessageBox.Show("Send!");
                return true;
            }
            MessageBoxResult resultconnected = MessageBox.Show("Error, Not Connected! Try Restarting The Programm!");
            return false;
        }

        public async Task<bool> SendAllPosition(Invoice Invoices)
        {
            if (mqttClient.IsConnected)
            {
                foreach (var Position in Invoices.Positions)
                {
                    string topic = $"invoice/position";
                    string payload = $"ID: {Position.Id}; ItemNr: {Position.ItemNr} Price: {Position.Price} Qty: {Position.Qty}";
                    await SendMqtt(payload, topic);
                }


                string topic2 = $"invoice/rechnung";
                string payload2 = $"ID: {Invoices.Id} Date: {Invoices.InvoiceDate} Amount: {Invoices.Amount} Name: {Invoices.CustomerName} Adress: {Invoices.CustomerAddress}";
                await SendMqtt(payload2, topic2);
                MessageBoxResult resultsend = MessageBox.Show("Send!");
                return true;
            }
            MessageBoxResult resultconnected = MessageBox.Show("Error, Not Connected! Try Restarting The Programm!");
            return false;
        }

        public async Task<bool> SendInvoiceJson(Invoice Invoices)
        {
            if (mqttClient.IsConnected)
            {
                foreach (var Position in Invoices.Positions)
                {
                    string topic = $"invoice/position";
                    //Json Konvertieren
                    string payload = JsonConvert.SerializeObject(Invoices);
                    await SendMqtt(payload, topic);
                }
                MessageBoxResult resultsend = MessageBox.Show("Send!");
                return true;
            }
            MessageBoxResult resultconnected = MessageBox.Show("Error, Not Connected! Try Restarting The Programm!");
            return false;

            return true;
        }

        public async Task<bool> SendAllPositionJson(Invoice Invoices)
        {
            if (mqttClient.IsConnected)
            {
                foreach (var Position in Invoices.Positions)
                {
                    string topic = $"invoice/position";
                    string payload = JsonConvert.SerializeObject(Position);
                    await SendMqtt(payload, topic);
                }


                string topic2 = $"invoice/rechnung";
                string payload2 = JsonConvert.SerializeObject(Invoices);
                await SendMqtt(payload2, topic2);
                MessageBoxResult resultsend = MessageBox.Show("Send!");
                return true;
            }
            MessageBoxResult resultconnected = MessageBox.Show("Error, Not Connected! Try Restarting The Programm!");
            return false;
        }

    }
}
