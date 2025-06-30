using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyThreadapp
{
    internal class Reflction_demo
    {

        public void demo1()
        {
            Type t = typeof(string[]);
            Console.WriteLine(t.FullName); // Outputs: System.String
            Console.WriteLine(t.IsValueType);//false
            Console.WriteLine(t.IsAbstract);//false
            Console.WriteLine(t.IsArray);//true
            Console.WriteLine(t.IsSealed); //true
        }

        public void demo2()
        {// Get the Type object for MyClass
            Type myType = typeof(MyClass);
            Console.WriteLine($"Type Name: {myType.FullName}");
            Console.WriteLine($"Assembly Name: {myType.Assembly.FullName}");
            Console.WriteLine($"Is Class: {myType.IsClass}");
            Console.WriteLine($"Is Public: {myType.IsPublic}");
            Console.WriteLine($"Base Type: {myType.BaseType}");

            // Get Constructors
            Console.WriteLine("\nConstructors:");
            ConstructorInfo[] constructors = myType.GetConstructors();
            foreach (var ctor in constructors)
            {
                Console.WriteLine($"- {ctor}");
            }

            Console.WriteLine("\nMethods:");
            MethodInfo[] m = myType.GetMethods();
            foreach (var method in m)
            {
                Console.WriteLine($"- {method.Name}");
            }

            Console.WriteLine("\nProperties:");
            PropertyInfo[] p = myType.GetProperties();
            foreach (var prop in p)
            {
                Console.WriteLine($"- {prop.Name}");
            }
        }

        public void demo3()
        {
            Assembly asm = Assembly.LoadFrom("C:\\Users\\pallapu.sandhya\\source\\repos\\MyThreadapp\\class1\\bin\\Debug\\class1.dll");
            Type[] t = asm.GetTypes();
            foreach (var item in t)
            {
                Console.WriteLine(item.Name);

                Console.WriteLine("-----------------");
                foreach (var i in item.GetMethods())
                {
                    Console.WriteLine(i.Name);
                }
            }
        }

        public void demo4()
        {
            Assembly asm = Assembly.LoadFrom("C:\\Users\\pallapu.sandhya\\source\\repos\\MyThreadapp\\class1\\bin\\Debug\\class1.dll");
            Type t = asm.GetType("MyLib.Class1");
            dynamic o=Activator.CreateInstance(t);
            o.Add(10,20);

        }
    }
}
