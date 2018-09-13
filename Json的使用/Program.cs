using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Json的使用1
{
    /// <summary>
    /// 方法1：JavaScriptSerializer类:   序列化，反序列化
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            //序列化操作
            JavaScriptSerializer jss = new JavaScriptSerializer();
            var json = new { name = "hans", age = "21" };
            string str = jss.Serialize(json);
            Console.WriteLine(str);

            //反序列化操作
            Person person = jss.Deserialize<Person>(str);
            Console.WriteLine(person.age);
        }
    }

    [Serializable]
    public class Person
    {
        public string name { get; set; }
        public int age { get; set; }
    }

}
