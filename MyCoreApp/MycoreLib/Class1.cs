using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
namespace MycoreLib
{
    public class Class1
    {
        public void hello()
        {
            Console.WriteLine("hello called");
        }


    }
   public  class StudentsModel
    {
        public int StudentId { get; set; }
        public string StudentsName { get; set; }
        public int TotalMarks { get; set; }
        public string[] Skills { get; set; }
        public DateTime DateOfJoining { get; set; }
    }
    public delegate bool StudentsFilter(StudentsModel students);
    public class Studentsdata
    {

        List<StudentsModel> students = new List<StudentsModel>
{
    new StudentsModel { StudentId = 1, StudentsName = "Akhilesh", TotalMarks = 85, Skills = new[] {"C#", "SQL", "Data Structures"}, DateOfJoining = new DateTime(2023, 1, 15) },
    new StudentsModel { StudentId = 2, StudentsName = "Kusuma", TotalMarks = 78, Skills = new[] {"Python", "Machine Learning", "Data Analysis"}, DateOfJoining = new DateTime(2022, 8, 10) },
    new StudentsModel { StudentId = 3, StudentsName = "Jayanth", TotalMarks = 90, Skills = new[] {"Java", "Spring Boot", "Microservices"}, DateOfJoining = new DateTime(2025, 5, 22) },
    new StudentsModel { StudentId = 4, StudentsName = "Rakshitha", TotalMarks = 76, Skills = new[] {"JavaScript", "React", "Node.js","Blazor"}, DateOfJoining = new DateTime(2022, 11, 7) },
    new StudentsModel { StudentId = 5, StudentsName = "Madhu", TotalMarks = 82, Skills = new[] {"HTML", "CSS", "UI/UX Design"}, DateOfJoining = new DateTime(2023, 3, 30) },
    new StudentsModel { StudentId = 6, StudentsName = "Naveena", TotalMarks = 88, Skills = new[] {"Angular", "TypeScript", "Docker"}, DateOfJoining = new DateTime(2023, 6, 5) },
    new StudentsModel { StudentId = 7, StudentsName = "Satish", TotalMarks = 79, Skills = new[] {"Swift", "Kotlin", "Mobile Development"}, DateOfJoining = new DateTime(2022, 9, 12) },
    new StudentsModel { StudentId = 8, StudentsName = "Sailesh", TotalMarks = 94, Skills = new[] {"Cloud Computing", "AWS", "DevOps","MVC"}, DateOfJoining = new DateTime(2023, 4, 25) },
    new StudentsModel { StudentId = 9, StudentsName = "Sushmitha", TotalMarks = 80, Skills = new[] {"Cybersecurity", "Ethical Hacking", "Network Security"}, DateOfJoining = new DateTime(2022, 7, 18) },
    new StudentsModel { StudentId = 10, StudentsName = "Pranitha", TotalMarks = 87, Skills = new[] {"Big Data", "Hadoop", "Spark"}, DateOfJoining = new DateTime(2025, 5, 22) },
    new StudentsModel { StudentId = 11, StudentsName = "Divya", TotalMarks = 92, Skills = new[] {"AI", "Deep Learning", "Neural Networks"}, DateOfJoining = new DateTime(2023, 5, 10) },
    new StudentsModel { StudentId = 12, StudentsName = "Sandhya", TotalMarks = 75, Skills = new[] {"Blockchain", "Cryptography", "Smart Contracts"}, DateOfJoining = new DateTime(2022, 10, 3) },
    new StudentsModel { StudentId = 13, StudentsName = "Sultana", TotalMarks = 83, Skills = new[] {"Software Testing", "Automation", "Selenium"}, DateOfJoining = new DateTime(2023, 1, 22) }
};




        public IEnumerable<StudentsModel> Getstudents()
        {
            return students;
        }

        public IEnumerable<StudentsModel> showcurrent()
        {
            var res= students.Where(s=>s.DateOfJoining==DateTime.Today);
            return res;
        }

        public IEnumerable<StudentsModel>showcurrent1(int x)
        {
            var res = students.Where(s => s.StudentsName.Length == x);
            return res;
        }
        public IEnumerable<StudentsModel> showcurrent2()
        {
            var res = students.Where(s => s.StudentsName.StartsWith("S") && s.StudentsName.EndsWith("a"));
            return res;
        }
        public IEnumerable<StudentsModel> showskillbychar()
        {
            var res = students.Where(s => s.Skills.Any(skill => skill.StartsWith("C")));
            return res;
        }
        public IEnumerable<StudentsModel> showhighest()
        {
            var res=students.OrderByDescending(s=>s.TotalMarks).Take(3);
            return res;
        }
       public IEnumerable<StudentsModel> showskills()
        {
            var r = students.Where(s => s.Skills.Count()>3);
            return r;
        }

        public IEnumerable<StudentsModel> showstudents()
        {
            var res = students.Where(s => s.StudentsName == "Madhu" || s.StudentsName == "Satish" || s.StudentsName == "Akhilesh" || s.StudentsName == "Rakshitha" || s.StudentsName == "Sailesh");
            return res;
        }

        public IEnumerable<StudentsModel> showreg()
        {
            Regex regex = new Regex("[A-K]");
            var res = students.Where(s => regex.IsMatch(s.StudentsName));
            return res;

        }

        public IEnumerable<StudentsModel> showdel()
        {
            StudentsFilter f = s => s.TotalMarks > 80;
            return students.Where(s => f(s));
        }

        public void showbydelay()
        {
            var filtered = students.Where(s => s.TotalMarks > 80);

            Task t = Task.Run(async () =>
            {
                foreach (var student in filtered)
                {
                    Console.WriteLine(student.StudentsName);
                    await Task.Delay(1000);  
                }
            });

            t.Wait();  
        }
        public void showdata()
        {
            var res = students.Where(s => s.TotalMarks > 80).ToList();
            FileStream fs = new FileStream("C:\\Student\\st.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xr = new XmlSerializer(typeof(List<StudentsModel>));
            xr.Serialize(fs, res);
            fs.Close();
            fs.Dispose();
            Console.WriteLine("File created!!");
        }
        public async void readdata()
        {
            FileStream fs = new FileStream("C:\\Student\\st.xml", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
           string data= await sr.ReadToEndAsync();
           
            Console.WriteLine(data);
        
        }

    }



    public static class StudentsExtensions
    {
        public static IEnumerable<string> extension(this IEnumerable<StudentsModel> students)
        {
            return students
                .Where(s => s.StudentsName.Contains("a") && s.StudentsName.Length == 7)
                .Select(s => s.StudentsName.ToUpper());
        }
    }
}
