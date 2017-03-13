using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;

namespace ZigZagTest
{
    public delegate void ReceiveLine(string Line);

    public abstract class DataReceiver
    {
        //dane Receivera
        private BackgroundWorker AsyncReaderThread;
        public ReceiveLine OnDataReceived;
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


        //przeciążalne metody implementujące czytanie linii faktycznego Receivera, np. UDP
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


        protected override void Configure()
        {
            throw new NotImplementedException();
        }

        protected override void Cleanup()
        {
            throw new NotImplementedException();
        }

        protected override void ReadAsync()
        {
            throw new NotImplementedException();
        }

        protected override void ReactToException()
        {
            throw new NotImplementedException();
        }
    }
}
