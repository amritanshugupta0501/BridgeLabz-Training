using System;
using System.IO;
using System.Text;

class TextFileReplicator
{
    static void Main()
    {
        string sourcePath = "source.txt";
        string destPath = "destination.txt";

        try
        {
            if (!File.Exists(sourcePath))
            {
                using (FileStream fs = File.Create(sourcePath))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("This is some sample text.");
                    fs.Write(info, 0, info.Length);
                }
            }

            using (FileStream sourceStream = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (FileStream destStream = new FileStream(destPath, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;
                while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    destStream.Write(buffer, 0, bytesRead);
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}