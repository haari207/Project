using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace MyconsoleApp
{
    internal class IOstreamsdemo
    {
        public void demo1()
        {
            FileStream fs=new FileStream(@"c:\\Mydir\\hello.txt",FileMode.OpenOrCreate,FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("hello world");
            sw.WriteLine("Have a great day!");
            sw.WriteLine("hi");
            sw.Close();
            fs.Close();
            fs.Dispose();
            Console.WriteLine("FILE CREATED SUCCESSFULLY");
        }
        public void demo2()
        {
            FileStream fs = new FileStream(@"c:\\Mydir\\hello.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs);
            string data=sr.ReadToEnd();
            Console.WriteLine(data);
            sr.Close();
            fs.Close();
            fs.Dispose();
        }
        public void demo3()
        {
            //how file works
            FileInfo f= new FileInfo(@"c:\\Mydir\\hello.txt");
            Console.WriteLine(f.FullName);
            Console.WriteLine(f.Length);
            Console.WriteLine(f.CreationTime);
            Console.WriteLine(f.DirectoryName);
            Console.WriteLine(f.LastAccessTime);
            Console.WriteLine(f.IsReadOnly);

        }
        public void demo4()
        {
            FileStream fs = new FileStream(@"c:\\Mydir\\hello.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryWriter b=new BinaryWriter(fs);
            b.Write(100);
            b.Write("Ajay");
            b.Write(5.8);
            b.Write(true);
            b.Close();
            fs.Close();
            fs.Dispose();
            Console.WriteLine("bin file created successfully");
        }
        public void demo5()
        {
            FileStream fs = new FileStream(@"c:\\Mydir\\hello.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryReader br = new BinaryReader(fs);
            int a=br.ReadInt32();
            String e=br.ReadString();
            double c=br.ReadDouble();
            bool d = br.ReadBoolean();
            Console.WriteLine($"{a} {e} {c} {d}");
            br.Close();
            fs.Close();
            fs.Dispose();
        }
      
        public void demo6()
        {
            FileStream fs=new FileStream(@"c:\\Mydir\\studentsdata.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryWriter b = new BinaryWriter(fs);
            studentsdata[] s = new studentsdata[3]
            {
                new studentsdata() { sid = 101, sname = "Ajay", height = 5.0 },
                new studentsdata() { sid = 102, sname = "jay", height = 5.7 },
                new studentsdata() { sid = 103, sname = "vinay", height = 5.8 }
            };

            foreach(var item in s)
            {
                b.Write(item.sid);
                b.Write(item.sname);
                b.Write(item.height);
            }
            b.Close();
            fs.Close();
            fs.Dispose();
            Console.WriteLine("File created successfully");
        }
        public void demo7()
        {
            studentsdata ob=new studentsdata();
            FileStream fs=new FileStream(@"c:\\Mydir\\studentsdata.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryReader b = new BinaryReader(fs);
            while (fs.Position < fs.Length)
            {
                ob.sid = b.ReadInt32();
                ob.sname = b.ReadString();
                ob.height = b.ReadDouble();
                Console.WriteLine($"{ob.sid}  {ob.sname}  {ob.height}");
            }
            b.Close();
            fs.Close();
            fs.Dispose();
        }

        public void Readdata(TextReader r)
        {
            string st;
            while ((st=r.ReadLine())!= null)
            {
                Console.WriteLine(st);
            }
        }
        public void demo8()
        {
            string st = "Simple data \n from testing \n Memory Stream!!";
            byte[] b=System.Text.Encoding.UTF8.GetBytes(st);
            MemoryStream fs = new MemoryStream(b);
            StreamReader r = new StreamReader(fs);
            string line= r.ReadToEnd();
            Console.WriteLine(line);
            r.Close();
            fs.Close();
            fs.Dispose();
        }

        public void demo9()
        {
            //Directory.CreateDirectory("c:\\hello");
            //Console.WriteLine("directory created successfully!");
            Console.WriteLine("Enter directory file name:");
            string st = Console.ReadLine();
            if (Directory.Exists(st))
            {

                string[] f= Directory.GetFiles(st);
                if (f.Length == 0)
                {
                    Console.WriteLine("no files");
                }
                else
                {
                    foreach (string s in f)
                    {
                        Console.WriteLine(s);
                    }
                }
            }
            else
            {
                Console.WriteLine("DIRECTORY DOESNOT EXIT CREATE ONE ");
                Console.WriteLine($"WANT TO CREATE A NEW ? Y/N:");
                string S = Console.ReadLine();
                if (S == "Y")
                {
                    Directory.CreateDirectory(st);
                    string filepath = Path.Combine(st, "hi.txt");
                    string filecontent = "This is a new sample  file created";
                    System.IO.File.WriteAllText(filepath, filecontent);
                    Console.WriteLine("File created");
                    string rd = System.IO.File.ReadAllText(filepath);
                    Console.WriteLine(rd);
                }
                else
                {
                    Console.WriteLine("Exit program");
                    return;
                }
            }
        }
        public void demo10()
        {

            //path
            string s = "c:\\testing\\hello.txt";
            string st=Path.GetDirectoryName(s);
            string fn=Path.GetFileName(s);
            string ex=Path.GetExtension(s);
            string r=Path.GetPathRoot(s);
            string fp=Path.GetFullPath(fn);
            Console.WriteLine($"Directory Name:{st}");
            Console.WriteLine($"File Name:{fn}");
            Console.WriteLine($"Extension of a file:{ex}");
            Console.WriteLine($"RootPath:{r}");
            Console.WriteLine($"Full Path:{fp}");

        }

    }

    class studentsdata
    {
        public int sid { get; set; }
        public string sname { get; set; }
        public double height { get; set; }
    }
}
