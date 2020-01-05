using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kanchan_Selenium
{
    class FilesEx
    {

        public static void Main(String[] args)
        {
            string filepath = "D://Test//kanchan123.txt";

            //File.Create(filepath);
            

            File.WriteAllText(filepath, "Hello this is my first file write");

            File.AppendAllText(filepath, "Adding text");

            Console.WriteLine(File.ReadAllText(filepath));

            string dest = "D://test//lankesh123.txt";
            File.Copy(filepath,dest );

            Console.WriteLine("lankesh text" + File.ReadAllText(dest));

            Console.WriteLine("File Equals " + File.Equals(filepath, dest));


            File.Delete("D://test//lankesh123.txt");

            Console.WriteLine("File Exists ? " + File.Exists(dest));

            Console.WriteLine("Created on " + File.GetCreationTime(filepath));

            //   File.Move(filepath, "D://kanchan1234.txt");


            FileStream fs = new FileStream("D://Test//fs123.txt", FileMode.Create, FileAccess.ReadWrite);

            string str1 = "this is filestream";



            byte[] b = new byte[100];

            for (int x = 0; x < str1.Length; x++)
                fs.WriteByte((byte)str1[x]);

            fs.Flush();

            fs.Position = 0;

            int d = fs.Read(b, 0, str1.Length);

            for (int x = 0; x < d; x++)
                Console.Write((char)b[x]);


            fs.Position = 0;
            for (int x = 0; x < str1.Length; x++)
                Console.Write((char)fs.ReadByte());


            

            Console.ReadKey();
        }
    }
}
