using System;
using System.IO;
using System.Diagnostics;

class EfficientFileCopier
{
    static void Main()
    {
        string sourceFile = "largefile.dat";
        string destFile = "copy.dat";
        
        byte[] data = new byte[1024 * 1024 * 10]; 
        new Random().NextBytes(data);
        File.WriteAllBytes(sourceFile, data);

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
        using (FileStream fsWrite = new FileStream(destFile, FileMode.Create, FileAccess.Write))
        using (BufferedStream bsRead = new BufferedStream(fsRead))
        using (BufferedStream bsWrite = new BufferedStream(fsWrite))
        {
            byte[] buffer = new byte[4096];
            int bytesRead;
            while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                bsWrite.Write(buffer, 0, bytesRead);
            }
        }

        stopwatch.Stop();
        Console.WriteLine($"Time elapsed: {stopwatch.ElapsedMilliseconds} ms");
    }
}