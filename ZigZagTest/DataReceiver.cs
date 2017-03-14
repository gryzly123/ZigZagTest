using System;
using System.ComponentModel;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace ZigZagTest
{
    public delegate void ReceiveLine(string Line);

    public abstract class DataReceiver
    {
        //dane Receivera
        private BackgroundWorker AsyncReaderThread;
        protected ReceiveLine OnDataReceived;
        private bool BreakLoop = false;

        //metody do uruchamiania i zakończania Receivera
        public void StartReading()
        {
            BreakLoop = false;
            AsyncReaderThread = new BackgroundWorker();
            AsyncReaderThread.DoWork += AyncReader_DoWork;
            AsyncReaderThread.RunWorkerAsync();
        }

        private void AyncReader_DoWork(object sender, DoWorkEventArgs Args)
        {
            Configure();
            try
            {
                while (!BreakLoop) ReadAsync();
            }
            catch(Exception E)
            {
                ReactToException();
            }
            Cleanup();
        }

        public void StopReading()
        {
            BreakLoop = true;
        }

        public void SetOnDataReceived(ReceiveLine OnReceived)
        {
            OnDataReceived = OnReceived;
        }

        //przeciążalne metody implementujące ścieżki komunikacji faktycznego Receivera, np. UDP
        protected abstract void ReadAsync();           //Oczekiwanie na kolejną linię
        protected abstract void Configure();           //Inicjalizacja
        protected abstract void Cleanup();             //Zakończenie pracy
        protected abstract void ReactToException();    //Reakcja na wyjątki try/catch
    }

    public class UDPReceiver : DataReceiver
    {
        private UdpClient UDPManager;
        private IPEndPoint UDPEndpoint;
        private Int16 Port;
        private IPAddress IP;

        public UDPReceiver(Int16 RequestedPort)
        {
            IP = IPAddress.Any;
            Port = RequestedPort;
        }

        public UDPReceiver(string RequestedIP, Int16 RequestedPort)
        {
            IP = IPAddress.Parse(RequestedIP);
            Port = RequestedPort;
        }

        protected override void Configure()
        {
            UDPManager = new UdpClient(Port);
            UDPEndpoint = new IPEndPoint(IP, Port);
            UDPManager.Connect(UDPEndpoint);
        }

        protected override void Cleanup()
        {
            UDPManager.Close();
        }

        protected override void ReadAsync()
        {
            Byte[] Message = UDPManager.Receive(ref UDPEndpoint);
            string Line = Encoding.ASCII.GetString(Message);
            OnDataReceived.Invoke(Line);
        }

        protected override void ReactToException()
        {
            throw new NotImplementedException();
        }
    }

    public class SerialReceiver : DataReceiver
    {
        SerialPort Port;

        public SerialReceiver(string PortName, Int32 BaudRate, Parity Parity, StopBits StopBits, Handshake Handshake)
        {
            Port.PortName = PortName;
            Port.BaudRate = BaudRate;
            Port.Parity = Parity;
            Port.StopBits = StopBits;
            Port.Handshake = Handshake;
        }        

        protected override void Cleanup()
        {
            Port.Close();
        }

        protected override void Configure()
        {
            Port.Open();
        }

        protected override void ReactToException()
        {
            throw new NotImplementedException();
        }

        protected override void ReadAsync()
        {
            string Line = Port.ReadLine();
            OnDataReceived.Invoke(Line);
        }
    }
}
