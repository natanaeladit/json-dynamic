using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace json_dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic jObject = new JObject();
            jObject.Property1 = (float)5.6;
            jObject.Property2 = "test";

            string jsonString = jObject.ToString(Formatting.None);
            Console.WriteLine(jsonString);

            dynamic json = JValue.Parse(jsonString);
            if (json != null)
                Console.WriteLine(json.Property1);
            else
                Console.WriteLine("json null");
        }
    }
}
