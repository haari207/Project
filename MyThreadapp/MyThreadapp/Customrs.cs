using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;
using System.Security.AccessControl;

namespace MyThreadapp
{
   public  class Customrs
    {
        [XmlAttribute]
        public int id {  get; set; }
        public string name { get; set; }    
        public int age {  get; set; }

        [XmlIgnore]
        public string address { get; set; }

        public void serializedata()
        {
            Customrs c = new Customrs() { 
            id = 1,
            name = "Ani",
            age = 38,
            address = "HYD"};


            FileStream fs = new FileStream("C:\\Customers\\c1.xml", FileMode.OpenOrCreate);

            XmlSerializer xr = new XmlSerializer(typeof(Customrs));
            xr.Serialize(fs,c);
            fs.Close();
            fs.Dispose();
            Console.WriteLine("File created successfully!!");
        }

        public void deserializedata()
        {
            Customrs c = new Customrs();

            FileStream fs = new FileStream("C:\\Customers\\c1.xml", FileMode.OpenOrCreate);
            XmlSerializer xr = new XmlSerializer(typeof(Customrs));
            c= (Customrs)xr.Deserialize(fs);
            Console.WriteLine(c.id);
            Console.WriteLine(c.name);
            Console.WriteLine(c.age);
        }


        public void serializetojson()
        {
            Customrs c = new Customrs()
            {
                id = 1,
                name = "Darshan",
                age = 31,
                address = "banglore"
            };
            string data=JsonSerializer.Serialize(c);
            File.WriteAllText("C:\\Customers\\c.json", data);
            Console.WriteLine("file created");

        }

        public void deserializedemo()
        {
            string data = File.ReadAllText("C:\\Customers\\c.json");
            Customrs ob = JsonSerializer.Deserialize<Customrs>(data);
            Console.WriteLine(ob.id);
            Console.WriteLine(ob.name);
            Console.WriteLine(ob.age);
            Console.WriteLine(ob.address);
        }

    }
}
