using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;

namespace json使用2
{
    /// <summary>
    /// 2.序列化和 反序列化的方法 DataContractJsonSerializer类
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person()
            {
                age = 20,
                name = "Hans"
            };
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Person));

            ///将序列化的json数据写入数据流
            MemoryStream msObj = new MemoryStream();

            js.WriteObject(msObj,p1);

            //从0这个位置开始读取流中的数据
            msObj.Position = 0;

            StreamReader sr = new StreamReader(msObj,Encoding.UTF8);
            string json = sr.ReadToEnd();

            Console.WriteLine(json);
            sr.Close();
            msObj.Close();

            //反序列化操作
            using (var ms=new MemoryStream(Encoding.Unicode.GetBytes(json)))
            {
                DataContractJsonSerializer deseralizer = new DataContractJsonSerializer(typeof(Person));
                ///反序列化ReadObjejct
                Person model = (Person)deseralizer.ReadObject(ms);
                Console.WriteLine(model.name);             
            }
            Console.ReadKey();
        }
    }
    [DataContract]
    public class Person
    {
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public int age { get; set; }
    }
}
