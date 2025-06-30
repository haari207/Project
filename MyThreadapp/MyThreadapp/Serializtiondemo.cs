using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data.SqlTypes;

namespace MyThreadapp
{
    [Serializable]
    internal class Serializtiondemo
    {
        public void serialization()
        {
            //obj is converted to file
            ArrayList li=new ArrayList();
            li.Add("Anu");
            li.Add("Hari");
            li.Add("kavya");
            li.Add("priya");
            li.Add("poojitha");
            li.Add("vidhu");

            FileStream fs=new FileStream("C:\\Students\\s1.xml", FileMode.OpenOrCreate);
            XmlSerializer xr=new XmlSerializer(typeof(ArrayList));
            xr.Serialize(fs, li);
            fs.Close();
            fs.Dispose();
            Console.WriteLine("File created successfully");

        }

        public void deserialization() {

            //file to obj code goes here

            ArrayList li = new ArrayList();

            FileStream fs = new FileStream("C:\\Students\\s1.xml", FileMode.OpenOrCreate);
            XmlSerializer xr= new XmlSerializer(typeof(ArrayList));
            li=(ArrayList)xr.Deserialize(fs);
            foreach(var item in li)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Total names present is:"+li.Count);

        }
        public void binaryserialize()
        {
            ArrayList ar=new ArrayList();
            ar.Add("Priya");
            ar.Add("pooja");
            ar.Add("hari");
            FileStream fs = new FileStream("C:\\Students\\s1.bin", FileMode.OpenOrCreate);

           BinaryFormatter bf = new BinaryFormatter();
           bf.Serialize(fs, ar);
            fs.Close();
            fs.Dispose();
            Console.WriteLine("File created !!");
        }


        public void binarydeserialize() { 


            ArrayList ar=new ArrayList();
            FileStream fs = new FileStream("C:\\Students\\s1.bin", FileMode.OpenOrCreate);

            BinaryFormatter bf = new BinaryFormatter();
           ar=(ArrayList)bf.Deserialize(fs);
            foreach(var item in ar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Total names present is:" + ar.Count);

            fs.Close();
            fs.Dispose();

        }
    }

}
