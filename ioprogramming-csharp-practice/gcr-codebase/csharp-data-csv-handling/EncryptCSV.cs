using System;
using System.IO;
using System.Text;
class EncryptCSV 
{
    static void Main(string[] args) 
    {
        EncryptCSV program = new EncryptCSV();
        program.ProcessEncryption();
    }
    void ProcessEncryption() 
    {
        using (StreamReader sr = new StreamReader("employees.csv"))
        using (StreamWriter sw = new StreamWriter("employees_encrypted.csv")) 
        {
            sw.WriteLine(sr.ReadLine());
            while (!sr.EndOfStream) 
            {
                string[] cols = sr.ReadLine().Split(',');
                cols[2] = ConvertToBase64(cols[2]);
                cols[3] = ConvertToBase64(cols[3]);
                sw.WriteLine(string.Join(",", cols));
            }
        }
    }
    string ConvertToBase64(string data) 
    {
        return Convert.ToBase64String(Encoding.UTF8.GetBytes(data));
    }
}