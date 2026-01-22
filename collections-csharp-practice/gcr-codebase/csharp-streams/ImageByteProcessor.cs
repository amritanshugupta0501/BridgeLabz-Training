using System;
using System.IO;

class ImageByteProcessor
{
    static void Main()
    {
        string inputImage = "input.jpg";
        string outputImage = "output.jpg";

        try
        {
            if (!File.Exists(inputImage))
            {
                File.WriteAllBytes(inputImage, new byte[100]); 
            }

            byte[] imageBytes;
            using (FileStream fs = new FileStream(inputImage, FileMode.Open, FileAccess.Read))
            using (MemoryStream ms = new MemoryStream())
            {
                fs.CopyTo(ms);
                imageBytes = ms.ToArray();
            }

            using (MemoryStream ms = new MemoryStream(imageBytes))
            using (FileStream fs = new FileStream(outputImage, FileMode.Create, FileAccess.Write))
            {
                ms.WriteTo(fs);
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}