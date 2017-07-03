using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;


namespace ActiveSupplier
{
    public class Worker
    {
        /// <summary>
        /// Metodo de verificacao de recebimento da notificao que sera executado em uma Thread
        /// </summary>

        private List<String> list;

        private volatile bool _shouldStop =false;

        private static UdpClient server;

        public void DoWork()
        {
            list = new List<string>();

            server = new UdpClient(9999);

            while (!_shouldStop)
            {
                String info = receive();

                if(info.Length>0)
                    list.Add(info);
            }
        }

        public void RequestStop()
        {
            _shouldStop = true;
        }

        static String receive()
        {
            IPEndPoint sender = new IPEndPoint(IPAddress.Any, 9999);
            byte[] data = new byte[1024];
            data = server.Receive(ref sender);
            String info = Encoding.ASCII.GetString(data, 0, data.Length);

            return info;
        }

        public List<string> Get()
        {
            return list;
        }
    }
}
