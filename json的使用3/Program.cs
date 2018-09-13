using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace json的使用3
{
    /// <summary>
    /// json的序列化，反序列化方法3.  json.net 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //序列化操作
            var json = new { user = new {name="Hans",age=23 } };
            string jsonData = JsonConvert.SerializeObject(json);
            Console.WriteLine(jsonData);

        }
    }

    public  class Person
    {         
        public string name { get; set; }
        public int age { get; set; }
    }
}
