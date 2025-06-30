namespace TestProject1
{
    using Microsoft.AspNetCore.Mvc;
    using Testdemo.Controllers;
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            HiController c=new HiController();
            var result = c.India();
            Assert.IsType<ViewResult>(result);
        }


        [Fact]
        public void Test2()
        {
            HiController c = new HiController();
            var result = c.Index();
           var viewres= Assert.IsType<ViewResult>(result);
            Assert.Equal("Index",viewres.ViewName);
        }

        [Fact]
        public void Test3()
        {
            HiController c = new HiController();
            var result = c.First();
            var viewres = Assert.IsType<ViewResult>(result);
            Assert.IsType<string[]>(viewres.Model);
        }

        [Fact]
        public void Test4()
        {
            HiController c = new HiController();
            var result = c.Second();
            var redirectresult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Second", redirectresult.ActionName);
        }
    }
}