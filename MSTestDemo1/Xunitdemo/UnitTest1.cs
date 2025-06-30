using System.Collections;
using System.Diagnostics;
using System.Reflection;
using MyclassLib;
using Xunit.Abstractions;

namespace Xunitdemo
{

    public class Myclasslevel : IDisposable
    {
        public Myclasslevel() {
            File.AppendAllText("C:\\Users\\pallapu.sandhya\\source\\repos\\MSTestDemo1\\Xunitdemo\\Xunitclass.txt", "Myclasslevel constructor called");
        }

        public void Dispose()
        {
            File.AppendAllText("C:\\Users\\pallapu.sandhya\\source\\repos\\MSTestDemo1\\Xunitdemo\\Xunitclass.txt", "Myclasslevel constructor called");

        }
    }

    public class UnitTest1 : IClassFixture<Myclasslevel>
    {

        private readonly ITestOutputHelper _output;
        //DI
        public UnitTest1(ITestOutputHelper output)
        {
            _output = output;
        }
        [Fact]
        [Mycls]
        public void Test1()
        {
            Assert.Equal(1, 1);
        }
        [Fact]
        public void Test2()
        {
            MyClass ob = new MyClass();
            int c = ob.Addnums(10, 20);
            Assert.Equal(30, c);
        }
        [Theory]
        //[InlineData(10,20,30)]

        [MemberData(nameof(testdata))]
        public void Test3(int a, int b, int c)
        {
            MyClass ob = new MyClass();
            int d = ob.Addnums(a, b);
            _output.WriteLine("hello");
            Assert.Equal(c, d);
        }
        public static IEnumerable<object[]> testdata => new List<object[]>
        {
            new object[] {2,2,4 },
            new object[] {3,4,7}
        };

        public class Mycls : Xunit.Sdk.BeforeAfterTestAttribute, IEnumerable<object[]>
        {
            public override void Before(MethodInfo methodUnderTest)
            {
                File.AppendAllText("C:\\Users\\pallapu.sandhya\\source\\repos\\MSTestDemo1\\Xunitdemo\\Xunit.txt", "Before method is called:" + methodUnderTest.Name);
            }
            public override void After(MethodInfo methodUnderTest)
            {
                File.AppendAllText("C:\\Users\\pallapu.sandhya\\source\\repos\\MSTestDemo1\\Xunitdemo\\Xunit.txt", "After method is called :" + methodUnderTest.Name);
            }

            public IEnumerator<object[]> GetEnumerator()
            {
                throw new NotImplementedException();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }

}
