using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
           
             BinarySerialization obj = new BinarySerialization();
             obj.Serialization();
             BinaryDeSerialization obj1 = new BinaryDeSerialization();
            // obj1.DeSerialization();
        }
    }
}
