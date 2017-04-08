using System;
using System.ComponentModel;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ZigZagTest
{
    public delegate void ReceiveLine(string Line);

    public abstract class DataReceiver
    {
        //dane Receivera
        private BackgroundWorker AsyncReaderThread;
        protected static ReceiveLine OnDataReceived = new ReceiveLine(NMEAParser.ParseLine);
        private bool BreakLoop = false;
        private bool Running = false;

        public bool IsRunning() { return !BreakLoop; }

        public void AddDelegateOnDataReceived(ReceiveLine NewDelegate)
        {
            OnDataReceived += NewDelegate;
        }

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
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            Configure();
            Running = true;
            //  try
            //  {
                    while (!BreakLoop) ReadAsync();
            //  }
            //  catch(Exception E)
            //  {
            //      ReactToException(E);
            //  }
            Running = false;
            Cleanup();
        }

        public void StopReading()
        {
            BreakLoop = true;
        }
        protected void ReactToException(Exception E)
        {
            MessageBox.Show(E.Message);
        }

        //przeciążalne metody implementujące ścieżki komunikacji faktycznego Receivera, np. UDP
        protected abstract void ReadAsync();           //Oczekiwanie na kolejną linię
        protected abstract void Configure();           //Inicjalizacja
        protected abstract void Cleanup();             //Zakończenie pracy
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
            //UDPManager.Connect(UDPEndpoint);
        }

        protected override void Cleanup()
        {
            //UDPManager.Close();
        }

        protected override void ReadAsync()
        {
            Byte[] Message = UDPManager.Receive(ref UDPEndpoint);
            string Line = Encoding.ASCII.GetString(Message);
            OnDataReceived.Invoke(Line);
        }
    }

    public class SerialReceiver : DataReceiver
    {
        SerialPort Port;

        public SerialReceiver(string PortName, Int32 BaudRate, Parity Parity, StopBits StopBits, Handshake Handshake)
        {
            Port = new SerialPort(PortName, BaudRate, Parity);
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

        protected override void ReadAsync()
        {
            string Line = Port.ReadLine();
            OnDataReceived.Invoke(Line);
        }
    }
}
