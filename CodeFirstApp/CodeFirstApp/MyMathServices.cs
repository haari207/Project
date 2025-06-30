namespace CodeFirstApp
{
    public interface Imyinter
    {
        string Addnums(int num1, int num2);
        public int  Add { get; set; }
    }
        public class MyMathServices : Imyinter
        {
            public string Addnums(int num1, int num2)
            {
                int num3 = num1 + num2;
                return "The sum is:" + num3;
            }
        public int Add { get; set; }

        }
    
}
