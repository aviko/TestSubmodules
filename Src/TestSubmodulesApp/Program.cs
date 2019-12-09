using Newtonsoft.Json;
using System;

namespace TestSubmodulesApp
{

    class TestPoco
    {
        public int IntVal { get; set; }
        public string StringVal { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var origPoco = new TestPoco { IntVal = 7, StringVal = "49" };

            var buf = BinaryConverter.BinaryConvert.SerializeObject(origPoco);

            var clonedPoco = BinaryConverter.BinaryConvert.DeserializeObject<TestPoco>(buf);

            Console.WriteLine(JsonConvert.SerializeObject(clonedPoco));

        }
    }
}
