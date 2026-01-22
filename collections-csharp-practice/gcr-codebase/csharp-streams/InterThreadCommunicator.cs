using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;
using System.Threading.Tasks;

class InterThreadCommunicator
{
    static void Main()
    {
        using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out))
        using (AnonymousPipeClientStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeServer.GetClientHandleAsString()))
        {
            Task writer = Task.Run(() =>
            {
                using (StreamWriter sw = new StreamWriter(pipeServer))
                {
                    sw.AutoFlush = true;
                    sw.WriteLine("Message from writer thread");
                }
            });

            Task reader = Task.Run(() =>
            {
                using (StreamReader sr = new StreamReader(pipeClient))
                {
                    string message = sr.ReadLine();
                    Console.WriteLine($"Received: {message}");
                }
            });

            Task.WaitAll(writer, reader);
        }
    }
}