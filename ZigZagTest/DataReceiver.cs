using System;
using System.Collections.Generic;
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
        protected ReceiveLine OnDataReceived = new ReceiveLine(NMEAParser.ParseLine) + new ReceiveLine(DataReceiver.AddLine);
        private bool BreakLoop = false;
        private bool Running = false;
        private static List<string> LineHistory = new List<string>();

        public bool IsRunning() { return !BreakLoop; }

        private static void AddLine(string Line)
        {
            LineHistory.Add(DateTime.UtcNow.ToString() + " :: " + Line);
        }

        public static List<string> GetLineHistory(int Count)
        {
            List<string> Result = new List<string>();
            int LimitUp = LineHistory.Count;
            int LimitDown = (Count == -1) ? 0 : LimitUp - Count;
            LimitDown = (LimitDown < 0) ? 0 : LimitDown;
            for (int i = LimitDown; i < LimitUp; i++) Result.Add(LineHistory[i]);
            return Result;
        }

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
            //konfiguracja kropek i przecinków
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";
            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            Configure();
            Running = true;

            while (!BreakLoop)
            {
                try { ReadAsync(); }
                catch (Exception E) { ReactToException(E); }
            }

            Running = false;
            Cleanup();
        }

        public void StopReading()
        {
            BreakLoop = true;
        }
        protected void ReactToException(Exception E)
        {
            OnDataReceived.Invoke("Error: " + E.ToString());
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
        }

        protected override void Cleanup() { }

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
