﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Configuration;
using System.Diagnostics;

namespace Server
{
    public class Server
    {
        Socket socket;
        public static List<ClientHandler> klijenti=new List<ClientHandler>();
        public Server()
        {
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }
        public void Start()
        {
       
         IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(ConfigurationManager.AppSettings["ip"]), int.Parse(ConfigurationManager.AppSettings["port"]));   
            socket.Bind(endPoint);

            socket.Listen(5);

            Thread thread = new Thread(AcceptClient);
            thread.Start();

        }

        private void AcceptClient()
        {
            try
            {
                while (true)
                {
                    Socket klijentskiSoket = socket.Accept();
                    ClientHandler handler = new ClientHandler(klijentskiSoket);
                    klijenti.Add(handler);
                    Thread klijentskaNit = new Thread(handler.HandleRequest);
                    klijentskaNit.Start();
                }
            }
            catch (SocketException ex)
            {
                Debug.WriteLine(">>>>>>>> "+ex.Message);
            }
        }

        public void Stop()
        {
            socket.Close(); //ne prima nove konekcije
            foreach(ClientHandler client in klijenti)
            {
                client.ZaustaviKlijente();
            }
            klijenti.Clear();
        }


    }

}
