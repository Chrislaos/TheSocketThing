using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking.Sockets;
using Windows.Networking;
using Windows.Networking.Connectivity;
using Windows.Networking.NetworkOperators;
using Windows.Networking.BackgroundTransfer;
using System.IO;

namespace Networking
{
    public interface IClient
    {
        event DisconnectedHandler Disconnected;
        event MessageReceivedHandler MessageReceived;
        event MessageSubmittedHandler MessageSubmitted;

        public delegate void MessageReceivedHandler(Client N, String Msg);
        public delegate void MessageSubmittedHandler(Client N, String Msg);
        public delegate void DisconnectedHandler(Client N);

        async void StartClient();
        void StartClient(String Hostname, String Port);
        bool IsConnected();
        async void Receive();
        void Send(String msg, bool close);
        void close();

    }

    public class Client : IClient
    {
        private StreamSocket _socket;
        private static HostName _localHost;
        private HostName _remoteHost;
        private String _serviceName;
        private EndpointPair _endpointpair;


        public Client()
        {
            _socket = new StreamSocket();
            _localHost = new HostName("192.168.1.113");
            _remoteHost = new HostName("192.168.1.145");
            _serviceName = "1337";
            _endpointpair = new EndpointPair(_localHost, _serviceName, _remoteHost, _serviceName);

        }

        public event IClient.DisconnectedHandler Disconnected;

        public event IClient.MessageReceivedHandler MessageReceived;

        public event IClient.MessageSubmittedHandler MessageSubmitted;

        async public void StartClient()
        {
            await _socket.ConnectAsync(_endpointpair);
        }

        public void StartClient(string Hostname, string Port)
        {
            throw new NotImplementedException();
        }

        public bool IsConnected()
        {
            throw new NotImplementedException();
        }

        public void Receive()
        {

        }

        public void Send(string msg, bool close)
        {
            throw new NotImplementedException();
        }

        public void close()
        {
            throw new NotImplementedException();
        }
    }
}
