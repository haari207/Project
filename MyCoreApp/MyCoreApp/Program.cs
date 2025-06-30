//See https://aka.ms/new-console-template for more information

using MycoreLib;
using Newtonsoft.Json;

Console.WriteLine("Hello, World!");

//var data = new
//{
//    studid = 1,
//    studname = "Ram",
//    studaddress = "Hyd"
//};
//Console.WriteLine($"{data.studid} {data.studname} {data.studaddress}");

//string json = JsonConvert.SerializeObject(data, Formatting.Indented);
////Console.WriteLine(json);
//MycoreLib.Class1 ob=new MycoreLib.Class1();
//ob.hello();        
Studentsdata st=new  Studentsdata();
//IEnumerable<StudentsModel> students = st.Getstudents();
//foreach (var student in students)
//{
//    Console.WriteLine($"ID: {student.StudentId}, Name: {student.StudentsName}, Marks: {student.TotalMarks}, Skills: {string.Join(", ", student.Skills)}, DOJ: {student.DateOfJoining:yyyy-MM-dd}");
//}

//IEnumerable<StudentsModel> students1 = st.showcurrent();
//foreach(var student in students1)
//{
//    Console.WriteLine($"{student.StudentsName}");
//}
//Console.WriteLine("===============");
//IEnumerable<StudentsModel> student2 = st.showcurrent1(6);
//foreach (var student in student2)
//{
//    Console.WriteLine($"{student.StudentsName}");
//}
//Console.WriteLine("=====================");
//IEnumerable<StudentsModel> students3 = st.showcurrent2();
//foreach (var student in students3)
//{
//    Console.WriteLine($"{student.StudentsName}");
//}
//Console.WriteLine("==========================");
//IEnumerable<StudentsModel> students4 = st.showskillbychar();
//foreach (var student in students4)
//{
//    Console.WriteLine($"{student.StudentsName} {string.Join(", ", student.Skills)}");
//}
//IEnumerable<StudentsModel> students5 = st.showhighest();
//foreach (var student in students5)
//{
//    Console.WriteLine($"{student.StudentsName} {student.TotalMarks}");
//}

//Console.WriteLine("==========================");

//IEnumerable<StudentsModel> Students6 = st.Getstudents();
//var filteredNames = Students6.extension();

//foreach (var name in filteredNames)
//{
//    Console.WriteLine(name);
//}
//Console.WriteLine("==========================");

//IEnumerable<StudentsModel> students7 = st.showskills();
//foreach (var student in students7)
//{
//    Console.WriteLine($"{student.StudentsName} {string.Join(", ", student.Skills)}");
//}
//Console.WriteLine("==========================");

//IEnumerable<StudentsModel> students8 = st.showstudents();
//foreach (var student in students8)
//{
//    Console.WriteLine($"{student.StudentsName}");
//}

Console.WriteLine("==========================");

//IEnumerable<StudentsModel> students9 = st.showreg();
//foreach (var student in students9)
//{
//    Console.WriteLine($"{student.StudentsName}");
//}

//st.showbydelay();
//st.showdata();
st.readdata();