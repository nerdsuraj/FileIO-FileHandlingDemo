using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    public class BinaryDeSerialization
    {
        
        public void DeSerialization()
        {
            FileStream fileStream = new FileStream(@"D:\Fellowship\Fellowship05-Day20_FileIO\SerializationDemo\Example.txt", FileMode.Open);
            BinaryFormatter formatter = new BinaryFormatter();
            Demo deserializationdemo = (Demo)formatter.Deserialize(fileStream);
            Console.WriteLine($"Application name {deserializationdemo.ApplicationName} ---ApplicationId    {deserializationdemo.ApplicationId}");
            Console.ReadKey();
        }
    }

}

