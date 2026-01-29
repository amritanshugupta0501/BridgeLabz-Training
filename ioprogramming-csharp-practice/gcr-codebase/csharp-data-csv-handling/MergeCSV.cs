using System;
using System.IO;
using System.Collections.Generic;
class MergeCSV 
{
    static void Main(string[] args) 
    {
        MergeCSV program = new MergeCSV();
        program.Merge();
    }
    void Merge() 
    {
        Dictionary<string, string> marksMap = new Dictionary<string, string>();
        using (StreamReader sr2 = new StreamReader("students2.csv")) 
        {
            sr2.ReadLine();
            while (!sr2.EndOfStream) 
            {
                string[] cols = sr2.ReadLine().Split(',');
                marksMap[cols[0]] = cols[1] + "," + cols[2];
            }
        }
        using (StreamReader sr1 = new StreamReader("students1.csv"))
        using (StreamWriter sw = new StreamWriter("merged_students.csv")) 
        {
            string header = sr1.ReadLine();
            sw.WriteLine(header + ",Marks,Grade");
            while (!sr1.EndOfStream) 
            {
                string line = sr1.ReadLine();
                string id = line.Split(',')[0];
                if (marksMap.ContainsKey(id)) 
                {
                    sw.WriteLine(line + "," + marksMap[id]);
                }
            }
        }
    }
}